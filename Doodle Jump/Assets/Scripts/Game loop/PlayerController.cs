using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float speed;
    private float moveInput;
    private Rigidbody2D rb;
    private Transform transform;

    // better jump
    public float fallMultiplier = 2.5f;

    private Vector2 screenBounds;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    void Update()
    {
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
            FindObjectOfType<GameManager>().LoadLevel();
        }
    }

    public void SpawnPlayer(float x, float y)
    {
        transform.position = new Vector2(x, y);
    }
}
