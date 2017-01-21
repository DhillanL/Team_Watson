using UnityEngine;
using System.Collections;

public class loadcluespage : MonoBehaviour {


    private string[] logbookplaces = { "logtext1", "logtext2", "logtext3", "logtext4", "logtext5", "logtext6", "logtext7", "logtext8" };

    void OnMouseDown()
    {
        GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(9, 24, -1);   // load to screen 
        GameObject.FindWithTag("logbookcrime").GetComponent<Transform>().position = new Vector3(185, 350, 0);  // moce off screen 


        for (int i = 0; i < 7; i++) // way to iterate through all of the logbooktext places 
        {
            string logbooktext = logbookplaces[i];
            GameObject.FindWithTag(logbooktext).GetComponent<Transform>().Translate(-290, 0, 0);
        }

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
