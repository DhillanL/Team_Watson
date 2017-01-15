using UnityEngine;
using System.Collections;

public class logbookbutton : MonoBehaviour {

    private Vector3 finish_pos = new Vector3(9,24, -1);
    

    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void OnMouseDown()
    { 
        // implement faster for loop way
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_logbook();
        GameObject.FindWithTag("logbook").GetComponent<Transform>().position = finish_pos;
        GameObject.FindWithTag("logtext1").GetComponent<Transform>().Translate(-290,0,0);
        GameObject.FindWithTag("logtext2").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext3").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext4").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext5").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext6").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext7").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logtext8").GetComponent<Transform>().Translate(-290, 0, 0);
        GameObject.FindWithTag("logbookcluetitle").GetComponent<Transform>().Translate(-310, 0, 0);

        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_logbook();
        

    }

    void Start () {
	
	}
	
	
	void Update () {
	
	}
}
