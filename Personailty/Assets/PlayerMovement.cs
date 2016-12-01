using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveRight;
    public KeyCode moveLeft;

    public float speed = 70f;
    private Rigidbody2D rb2D; //Rigidbody inside object



    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //get access to the Rigidbody

    }

    void Update()
    {
        if (Input.GetKey(moveRight))
        {
            rb2D.velocity = new Vector2(speed, 0);

        }
        else if (Input.GetKey(moveLeft))
        {
            rb2D.velocity = new Vector2(-speed, 0);
            
        }
        else
        {
            rb2D.velocity = Vector2.zero;
        }
    }
}