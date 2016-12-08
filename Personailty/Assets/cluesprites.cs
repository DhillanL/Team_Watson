using UnityEngine;
using System.Collections;

public class cluesprites : MonoBehaviour {

    public Sprite Dagger;
    public Sprite meatclever;
    public Sprite ruler;
    public Sprite tophat;
    public Sprite beanie;
    public Sprite flatcap;
    public Sprite cloth;
    public Sprite note;
    public Sprite pen;


    public Sprite getsprites_murder1(string clue)
    {
        switch (clue)
        {
            case ("Flick Knife"):
                return Dagger;
            case ("Meat Clever"):
                return meatclever;
            case ("Sharpened Metal Ruler"):
                return ruler;
            case ("Top Hat"):
                return tophat;
            case ("flat cap"):
                return flatcap;
            case ("beanie"):
                return beanie;
            case ("cloth with blood on"):
                return cloth;
            case ("Hand written note to Victim"):
                return note;
            default:
                return pen;
        }
    }

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
