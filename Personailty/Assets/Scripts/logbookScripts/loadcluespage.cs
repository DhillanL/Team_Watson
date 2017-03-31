using UnityEngine;
using System.Collections;

public class loadcluespage : MonoBehaviour {


    private string[] logbookplaces = { "logtext1", "logtext2", "logtext3", "logtext4", "logtext5", "logtext6", "logtext7", "logtext8" };
    private string[] logbookplaces2 = { "logtext1-2", "logtext2-2", "logtext3-2", "logtext4-2", "logtext5-2", "logtext6-2", "logtext7-2", "logtext8-2" };
    void OnMouseDown()
    {
        Debug.Log(GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn());
        if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1) // player 1 
        {
            GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(9, 24, -1);
            for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places 
            {
                string logbooktext = logbookplaces[i];
                GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(-290, 0, 0);
            }
        }
        else
        {
            GameObject.FindWithTag("logbook2").GetComponent<Transform>().position = new Vector3(9, 24, -1);
            for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places 
            {
                string logbooktext = logbookplaces2[i];
                GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(-290, 0, 0);
            }// load to screen 
        }

        GameObject.FindWithTag("logbookcrime").GetComponent<Transform>().position = new Vector3(185, 350, 0);  // moce off screen 


        

        GameObject.FindWithTag("logbookcluetitle").GetComponent<Transform>().Translate(-310, 0, 0);
        GameObject.FindWithTag("logbookcasetitle").GetComponent<Transform>().Translate(600, 0, 0);
        GameObject.FindWithTag("logbookcasetext").GetComponent<Transform>().Translate(600, 0, 0);


    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
