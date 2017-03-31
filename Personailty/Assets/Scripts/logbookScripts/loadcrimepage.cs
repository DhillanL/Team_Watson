using UnityEngine;
using System.Collections;

public class loadcrimepage : MonoBehaviour {

    private string[] logbookplaces = {"logtext1","logtext2","logtext3","logtext4", "logtext5", "logtext6", "logtext7", "logtext8" };
    private string[] logbookplaces2 = { "logtext1-2", "logtext2-2", "logtext3-2", "logtext4-2", "logtext5-2", "logtext6-2", "logtext7-2", "logtext8-2" };

    void OnMouseDown()
    {
        GameObject.FindWithTag("logbookcrime").GetComponent<Transform>().position = new Vector3(9,24,-1);
        GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(185, 188, 0);  // move out of the way
        GameObject.FindWithTag("logbook2").GetComponent<Transform>().position = new Vector3(185, 517, 0);
        if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1)
        {
            for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places and move them out of the way 
            {
                string logbooktext = logbookplaces[i];
                GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(290, 0, 0);
            }
        } else
        {
            for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places and move them out of the way 
            {
                string logbooktext = logbookplaces2[i];
                GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(290, 0, 0);
            }
        }
        

        GameObject.FindWithTag("logbookcluetitle").GetComponent<Transform>().Translate(310,0,0);  // move away old title 
        GameObject.FindWithTag("logbookcasetitle").GetComponent<Transform>().Translate(-600,0,0);
        GameObject.FindWithTag("logbookcasetext").GetComponent<Transform>().Translate(-600,0,0);

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
