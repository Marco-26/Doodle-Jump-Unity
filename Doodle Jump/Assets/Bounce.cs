using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private GameObject player;
    private Animator anim;
    public float platformNumber;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = player.GetComponent<Animator>();
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
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400f);
            }
            else if(platformNumber == 2)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900f);
            }
            else if (platformNumber == 3)
            {
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400f);
            }
            anim.SetTrigger("Stretch");
        }
    }
}
