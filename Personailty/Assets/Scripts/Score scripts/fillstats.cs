using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillstats : MonoBehaviour {

    // can be used on the final screen WIN and LOSE to load all of the stats onto teh screenso that it can be seen by the player, how well they did 

    public Text time;  // the text objects which will show the score and other required attributes to implement the score 
    public Text clues;
    public Text score;
    public GameObject Gamemanager;

    private void fill_stats()
    {
        //time.text ="Time: " + Gamemanager.GetComponent<gameManager>().get_mins().ToString() + ":" + Gamemanager.GetComponent<gameManager>().get_seconds().ToString("00");  // SET THE TEXT TO THE TIME IT TOOK TO WIN
       // clues.text ="Clues: " + get_clues().ToString() + " / 8"; // GATHER THE AMOUNT OF CLUES GATHER OUT OF 8 
       // score.text = make_score().ToString() ;    // WILL SHOW THE SCORE AFTER YOU HAVE CALCULATED IT , USING MAKE_SCORE
    }

    private int get_clues()
    {
        return Gamemanager.GetComponent<gameManager>().get_clues_no();  // gets the No. of clues found by the player through the game 
    }

    private int make_score()
    {
        int x = 0;  // add ways to set the score, EG: amount of clues found * time * multipler[win/lose]
        return x;
    }


	// Use this for initialization
	void Start () {
        
        //fill_stats();    //REMOVE COMMENT TO FILL STATS ON THE SCREEN 
      
    }
	
	
}
