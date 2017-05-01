// NEW FOR ASSESSMENT 4 
// USED TO ADD TO LOCK GREEN PART. IT DOES THE TEST TO SEE IF THE LINE HAS BEEN STOPPED INTHE CORRECT PLACE OR NOT 
// IMPLEMNETED AS A RCOLLIDER2D TO MAKE USE OF THE BUILD IN UNITY FUNCATIONALY 
// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

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
                Debug.Log("start2");  // If the lock has been stopped in the correct palce start the next lock 
                

            } else if (num == 2 )
            {
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().startlock3();
                Debug.Log("start3");

            } else
            {
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().lock_picked(true);
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().set_line_green();
                GameObject.FindWithTag("locks").GetComponent<Makelocks>().stopgame();  // if the player picks it here then they have won and can continue 
                

               
            }
        }
    }

   
}
