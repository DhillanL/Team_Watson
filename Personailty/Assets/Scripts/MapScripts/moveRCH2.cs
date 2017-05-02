using UnityEngine;
using System.Collections;

public class moveRCH2 : MonoBehaviour {

    //load RCH2 scene

    void OnMouseDown()
    {

        GameObject.FindWithTag("map").transform.position = new Vector3(-91, 191, -1);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_RCH2();
        GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Screen3";
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
