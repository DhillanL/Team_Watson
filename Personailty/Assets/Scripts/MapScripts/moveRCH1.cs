using UnityEngine;
using System.Collections;

public class moveRCH1 : MonoBehaviour {

    void OnMouseDown()
    {
        Debug.Log("click");
        GameObject.FindWithTag("map").transform.position = new Vector3(-91,191,-1);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_RCH1();
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
