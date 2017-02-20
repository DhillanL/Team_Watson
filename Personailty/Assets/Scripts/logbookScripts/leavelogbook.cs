using UnityEngine;
using System.Collections;

public class leavelogbook : MonoBehaviour {
    
    // script to close the logbook pages depending on which on you are on = clues or crime 
    // if x = 1 close the clues page
    // if x = 0 close the crime page 

    public int x;

    void OnMouseDown()
    {
        if (x == 1) // close the clues page 
        {
            GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(185, 188, 0);
            GameObject.FindWithTag("logtext1").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext2").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext3").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext4").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext5").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext6").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext7").GetComponent<Transform>().Translate(290, 0, 0);
            GameObject.FindWithTag("logtext8").GetComponent<Transform>().Translate(290, 0, 0);
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
