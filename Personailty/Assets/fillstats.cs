using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillstats : MonoBehaviour {

    public Text time;
    public GameObject Gamemanager;

    private void fill_stats()
    {
        time.text ="Time: " + Gamemanager.GetComponent<gameManager>().get_mins().ToString() + ":" + Gamemanager.GetComponent<gameManager>().get_seconds().ToString("00");
        Debug.Log(Gamemanager.GetComponent<gameManager>().get_seconds());
    }



	// Use this for initialization
	void Start () {

        fill_stats();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
