using UnityEngine;
using System.Collections;

public class DonotDestoryBottomGUI : MonoBehaviour {

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
