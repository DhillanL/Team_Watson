using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderLeftScreen : MonoBehaviour {

    /* ColiderLeftScreen is a script added to all of the scenes in the game so that when the player walks to the left hand side of the screen he/she will  move into the next room according to the map
     */

    public GameObject gamemanager;

    void OnTriggerEnter2D(Collider2D Col) // Triggered when the player goes to the far left collision box
    {
        Vector3 starting_pos_left = new Vector3(155, -21, 0); // Resets the position of the player if a new room has been entered;

        string col_tag = Col.gameObject.tag;
        string room = SceneManager.GetActiveScene().name;

        if (col_tag.Equals("Player"))
        {
            
            if (room.Equals("Room7"))
            {
                gamemanager.GetComponent<gameManager>().load_meetingroom(); // load the meeting room (scencename - Room3)
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Room5"))
            {
                gamemanager.GetComponent<gameManager>().load_upstairslecture(); // load the upsairs lecture hall (scenename - Room 7 )
                Col.transform.position = starting_pos_left;
            }
            else if ( room.Equals("Room4"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH2(); // load second main RCH room (scenename - Screen3 )
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Screen3"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH1(); // (scenename - Screen2 )
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Screen2"))
            {
                gamemanager.GetComponent<gameManager>().load_outside_lakes(); // (scenename - room6)
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Room6"))
            {
                gamemanager.GetComponent<gameManager>().load_outside_bottombalcony(); // (scenename - Room8)
                Col.transform.position = starting_pos_left;
            } else
            {
                Debug.Log("nope");
            }
                

        }
    }
}
