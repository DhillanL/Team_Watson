using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loadcasefile : MonoBehaviour {

    public GameObject gameman;
    public GameObject headshot;

    public Text Victim_name;
    public Text Victim_age;
    public Text victim_known_info;


    public void setcasefile()
    {
        gameManager info = gameman.GetComponent<gameManager>();
        Victim_name.text = "Name: " + info.get_whole_victim().Name;
        Victim_age.text = "Age: ";
        victim_known_info.text = info.get_crime();
        headshot.GetComponent<SpriteRenderer>().sprite = info.get_whole_victim().headshot;
    }

	// Use this for initialization
	void Start () {
        setcasefile();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
