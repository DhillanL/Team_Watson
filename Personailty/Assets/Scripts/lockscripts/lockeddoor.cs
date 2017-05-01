//NEW FOR ASSESSSMNET 4 
// ADDED TO THE HIDDEN DOOR, TESTS IF THE DOOR HAS BEEN REVELADED, IF SO THEN YOU ENTER IF IT 
// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class lockeddoor : MonoBehaviour {

    public bool visible = false; // BOOL used to test if the door has been found or not 


     void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.W) && visible) // the moving bookcase sets visible to true once it has been clicked and animation has finished 
        {
            GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_lockedroom(); // load the lock puzzle
            if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().istwoplayeron())
            {
                GameObject.FindWithTag("turn").GetComponent<turnswitcher>().start_loop(); //if its two player restsrt the time 
            }

        }

    }


    public void is_visible()  // public so that it can be accessed by the bookcase 
     {
        visible = true;
    }

}
