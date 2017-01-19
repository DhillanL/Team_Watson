using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logbook : MonoBehaviour {


    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
