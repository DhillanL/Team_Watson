using UnityEngine;
using System.Collections;

public class leavelogbook : MonoBehaviour {
    
    // script to close the logbook pages depending on which on you are on = clues or crime 
    // if x = 1 close the clues page
    // if x = 0 close the crime page 

    public int x;

    void OnMouseDown()
    {
         string[] logbookplaces = { "logtext1", "logtext2", "logtext3", "logtext4", "logtext5", "logtext6", "logtext7", "logtext8" };
         string[] logbookplaces2 = { "logtext1-2", "logtext2-2", "logtext3-2", "logtext4-2", "logtext5-2", "logtext6-2", "logtext7-2", "logtext8-2" };

        if (x == 1) // close the clues page 
        {
            GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(185, 188, 0);
            GameObject.FindWithTag("logbook2").GetComponent<Transform>().position = new Vector3(185, 517, 0);
            if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1)
            {
                for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places and move them out of the way 
                {
                    string logbooktext = logbookplaces[i];
                    GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(290, 0, 0);
                }
            }
            else
            {
                for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places and move them out of the way 
                {
                    string logbooktext = logbookplaces2[i];
                    GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(290, 0, 0);
                }
            }

            GameObject.FindWithTag("logbookcluetitle").GetComponent<Transform>().Translate(310, 0, 0);

            GameObject.FindWithTag("log_button").GetComponent<logbookbutton>().already_open = false;

        } else if (x == 0) // close the crime page 
        {
            GameObject.FindWithTag("logbookcrime").GetComponent<Transform>().position = new Vector3(185, 350, 0);
            GameObject.FindWithTag("log_button").GetComponent<logbookbutton>().already_open = false;
            GameObject.FindWithTag("logbookcasetitle").GetComponent<Transform>().Translate(600, 0, 0);
            GameObject.FindWithTag("logbookcasetext").GetComponent<Transform>().Translate(600, 0, 0);

        }

        GameObject.FindWithTag("Player").GetComponent<player>().walkT(); // set it so the player can walk again
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
