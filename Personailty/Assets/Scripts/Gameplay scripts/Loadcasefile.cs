using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loadcasefile : MonoBehaviour {

    // used on the case file screen to fill all of the information that is needed to show the player about the crime they are trying to solve

    public GameObject gameman;
    public GameObject headshot;
    

    public Text Victim_name;
    public Text Victim_age;
    public Text victim_known_info;
   


    public void setcasefile()
    {
        gameManager info = gameman.GetComponent<gameManager>();
        Victim_name.text = "Name: " + gameManager.victim.Name;
        Victim_age.text = "Age: " + info.get_whole_victim().age;
        victim_known_info.text = info.get_crime();
        headshot.GetComponent<SpriteRenderer>().sprite = info.get_whole_victim().headshot;
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().load_log_book_crime("Victim Name: " + Victim_name.text + "\n\nVictim Age: " + Victim_age.text + "\n\nKnown Info:\n " + victim_known_info.text);

    }

	// Use this for initialization
	void Start () {
        setcasefile();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
