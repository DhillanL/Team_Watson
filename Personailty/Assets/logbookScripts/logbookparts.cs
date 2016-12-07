using UnityEngine;
using System.Collections;

public class logbookparts : MonoBehaviour {


    public GameObject text1;
    public GameObject text2;

    public void load_logbook()
    {
        GameObject.FindWithTag("logbook").GetComponent<Logbook>().settext1(text1);
    }



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
