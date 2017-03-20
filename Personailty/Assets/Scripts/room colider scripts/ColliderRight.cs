using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderRight : MonoBehaviour {

    /* ColiderLeftScreen is a script added to all of the scenes in the game so that when the player walks to the right hand side of the screen he/she will  move into the next room according to the map
     */

    public GameObject gamemanager;

    void OnTriggerEnter2D(Collider2D Coll) // Triggered when the player goes to the far right collision box
    {

        Vector3 starting_pos_right = new Vector3(-155, -21, 0); // Resets the position of the player if a new room has been entered;

        string col_tag = Coll.gameObject.tag;

        string room = SceneManager.GetActiveScene().name;
        
        if (col_tag.Equals("Player"))
        {    
            if (room.Equals("Room7"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Room7";
                gamemanager.GetComponent<gameManager>().load_lakehousebalcony(); // load the balcony (Scenename - Rom5)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room3"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Room3";
                gamemanager.GetComponent<gameManager>().load_upstairslecture(); // (SceneName - Room7)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room8"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Room8";
                gamemanager.GetComponent<gameManager>().load_outside_lakes(); //(Sccenename - room6)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Screen3"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Screen3";
                gamemanager.GetComponent<gameManager>().load_kitchen(); // (scenename - Room4 )
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Screen2"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Screen2";
                gamemanager.GetComponent<gameManager>().load_RCH2(); // (Scenename - Screen3)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room6"))
            {
                GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Room6";
                gamemanager.GetComponent<gameManager>().load_RCH1(); // (scenename - Screen2)
                Coll.transform.position = starting_pos_right;
            } else
            {
                ;
            }

        }
    }

}
