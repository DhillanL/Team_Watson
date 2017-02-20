using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillstats : MonoBehaviour {

	// calculates the score using information from gameManager and timer

    public Text time;  // the contents of these Text objects will be shown on the win screen
    public Text clues;
    public Text score;
	public Text failed_accusations;
    public GameObject Gamemanager;

    private void fill_stats()
    {
		int seconds = Mathf.RoundToInt (timer.instance.getTime());
		time.text = "Time: " + seconds +" seconds"; // text time set to string repr of current timer value
		clues.text ="Clues: " + gameManager.clues_found + " / 8"; // GATHER THE AMOUNT OF CLUES GATHER OUT OF 8 
		failed_accusations.text = "Failed Accusations: " +gameManager.failed_accusations;
        score.text = "Overall Score: " + make_score() ;    // WILL SHOW THE SCORE AFTER YOU HAVE CALCULATED IT , USING MAKE_SCORE
    }

    private int make_score()
    {

		// Calculates the score -- faceless drones addition
		int accusations = gameManager.failed_accusations;
		float time = timer.instance.getTime() ;
		int clues_not_found = 8 - gameManager.clues_found;
		int score = 100;
		score -= clues_not_found * 5; // five points lost for each failed accusation, and clue not yet found
		score -= accusations * 5;
		score -= Mathf.RoundToInt (time / 20); // one point lost for every 20 seconds of playtime

        return score;
    }


	// Use this for initialization
	void Start () {
        
        fill_stats();    //REMOVE COMMENT TO FILL STATS ON THE SCREEN 
      
    }
	
	
}
