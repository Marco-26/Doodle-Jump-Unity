using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float speed;
    private float moveInput;
    private Rigidbody2D rb;

    // better jump
    public float fallMultiplier = 2.5f;
    private Vector2 screenBounds;

    // particle system
    [SerializeField] private Transform particleSpawn;
    [SerializeField] private GameObject particles;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){    Instantiate(particles, particleSpawn.position, particleSpawn.rotation); }
        
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        BetterJump();
        KillPlayer();
    }

    void BetterJump()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    // kill player if it gets out of screen boundaries

    void KillPlayer()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if(transform.position.y < (screenBounds.y - 20))
        {
            Instantiate(particles, particleSpawn.position, particleSpawn.rotation);
            this.gameObject.SetActive(false);
            FindObjectOfType<GameManager>().LoadLevel();
        }
    }

    public void DisablePlayer(){
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        this.enabled = false;
    }

    public void SpawnPlayer(float x, float y)
    {
        transform.position = new Vector2(x, y);
    }
}
