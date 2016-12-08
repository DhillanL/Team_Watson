using UnityEngine;
using System.Collections;

public class leavelogbook : MonoBehaviour {

    void OnMouseDown()
    {
        GameObject.FindWithTag("logbook").GetComponent<Transform>().position = new Vector3(185, 188, 0);
        GameObject.FindWithTag("logtext1").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext2").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext3").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext4").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext5").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext6").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext7").GetComponent<Transform>().Translate(290, 0, 0);
        GameObject.FindWithTag("logtext8").GetComponent<Transform>().Translate(290, 0, 0);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
