using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private bool moveDown = true;
    public Transform right;
    public Transform left;

    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x > right.transform.position.x)
            moveDown = true;
        else if (transform.position.x < left.transform.position.x)
            moveDown = false;

        if (moveDown)
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
}
