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
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_logbook();
        GameObject.FindWithTag("logbook").GetComponent<Transform>().position = finish_pos;
        GameObject.FindWithTag("logtext1").GetComponent<Transform>().Translate(-290,0,0);
        

    }

    void Start () {
	
	}
	
	
	void Update () {
	
	}
}
