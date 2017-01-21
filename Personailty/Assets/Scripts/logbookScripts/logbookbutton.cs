using UnityEngine;
using System.Collections;

public class logbookbutton : MonoBehaviour {

    // when you click on the logbook button in the bottom courner the OnMouseDown function will be called to load all of the UI elements into the window 

    private Vector3 finish_pos = new Vector3(9,24, -1);
    
    public bool already_open = false;

    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void OnMouseDown()
    {
        if (!already_open)
        {
            // implement faster for loop way
            GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_logbook();
            GameObject.FindWithTag("logbook").GetComponent<Transform>().position = finish_pos;
            GameObject.FindWithTag("logtext1").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext2").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext3").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext4").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext5").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext6").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext7").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logtext8").GetComponent<Transform>().Translate(-290, 0, 0);
            GameObject.FindWithTag("logbookcluetitle").GetComponent<Transform>().Translate(-310, 0, 0);

            GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_logbook();
            GameObject.FindWithTag("Player").GetComponent<player>().walkF(); // set it so the player cant move when the map is up
            GameObject.FindWithTag("Player").GetComponent<player>().set_vel_0();

            already_open = true;
        }
        

    }

  
}
