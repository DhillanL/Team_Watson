﻿using UnityEngine;
using System.Collections;

public class moveRCH1 : MonoBehaviour {

    //load RCH1 scene

    void OnMouseDown()
    {
        Debug.Log("click");
        GameObject.FindWithTag("map").transform.position = new Vector3(-91,191,-1);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_RCH1();
        GameObject.FindWithTag("Player").GetComponent<player>().PastScene = "Screen2";
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
