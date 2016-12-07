using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logbook : MonoBehaviour {

    public GameObject text1;
    public GameObject text2;

    int clue_count = 0;


    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    public void add_clue(clue clue)
    {
        if (clue_count<1)
        {
            text1.GetComponent<Text>().text = clue.info;
            clue_count++;
        } else
        {
            text2.GetComponent<Text>().text = clue.info;
            clue_count++;
        }
        
    }

    public void settext1(GameObject text1obj)
    {
        text1 = text1obj;
    }


  



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
