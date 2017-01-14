using UnityEngine;
using System.Collections;

public class MapCall : MonoBehaviour {

    private Vector3 finish_pos = new Vector3(-1,22,1);

    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

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
