using UnityEngine;
using System.Collections;

public class mousedowm : MonoBehaviour {

    public GameObject Player;
    public GameObject Headshot;
    public Sprite headshot;
   

    void OnMouseDown()
    {
        Player.GetComponent<player>().interact();
        Headshot.GetComponent<SpriteRenderer>().sprite = headshot; //need to replace with a better npc version

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
