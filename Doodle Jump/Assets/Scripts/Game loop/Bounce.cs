using UnityEngine;

public class Bounce : MonoBehaviour
{
    // private GameObject player;
    private PlayerController playerScript;
    public float platformNumber;

    private void Start() {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            //platformNumber(1) = Normal platform
            //platformNumber(2) = Big bounce platform
            //platformNumber(3) = Falling platform

            if (platformNumber == 1)
            {
                playerScript.Jump(400f);
            }
            else if(platformNumber == 2)
            {
                playerScript.Jump(900f);
            }
            else if (platformNumber == 3)
            {
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                playerScript.Jump(500f);     
            }
        }

    }
}
