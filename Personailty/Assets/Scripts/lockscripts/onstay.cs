using UnityEngine;
using System.Collections;

public class onstay : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))  // when you click the left mouse button  
        {
            Rigidbody2D rb;
            rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, 0);    // stop the line moving 

            int num = GameObject.FindWithTag("locks").GetComponent<Makelocks>().getlocknumber();

            if (num == 1)
            {
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().startlock2();
                Debug.Log("start2");
                

            } else if (num == 2 )
            {
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().startlock3();
                Debug.Log("start3");

            } else
            {
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().lock_picked(true);
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().stopgame();
                

               
            }
        }
    }

   
}
