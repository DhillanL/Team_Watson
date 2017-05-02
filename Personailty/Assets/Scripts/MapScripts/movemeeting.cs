using UnityEngine;
using System.Collections;

public class movemeeting : MonoBehaviour {

    //load meeting room scene

    void OnMouseDown()
    {

        GameObject.FindWithTag("map").transform.position = new Vector3(-91, 191, -1);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_meetingroom();
        GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Room7";
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
