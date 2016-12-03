using UnityEngine;
using System.Collections;

public class clickX : MonoBehaviour {


    private Vector3 finish_pos = new Vector3(-91,191,0);

    void OnMouseDown()
    {
        
        GameObject.FindWithTag("map").GetComponent<Map>().transform.position = finish_pos;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
