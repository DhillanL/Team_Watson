using UnityEngine;
using System.Collections;

public class DonotDestoryBottomGUI : MonoBehaviour {

    // applied to the GUI so it doesnt destory

    private static bool exsist= false;

    void Awake() // will not destroy the player on each new scene 
    {
        
            DontDestroyOnLoad(this.gameObject);
           
        
           

    }


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
