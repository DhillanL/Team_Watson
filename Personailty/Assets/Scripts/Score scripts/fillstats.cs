using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillstats : MonoBehaviour {

    // can be used on the final screen WIN and LOSE to load all of the stats onto the screen so that it can be seen by the player, how well they did 

    public Text time;  // the text objects which will show the score and other required attributes to implement the score 
    public Text clues;
    public Text score;
    public GameObject Gamemanager;

    private void fill_stats()
    {
		int seconds = Mathf.RoundToInt (timer.instance.getTime());
		time.text = "Time: " + seconds; // text time set to string repr of current timer value
		clues.text ="Clues: " + gameManager.clues_found + " / 8"; // GATHER THE AMOUNT OF CLUES GATHER OUT OF 8 
        score.text = "Score:" + make_score() ;    // WILL SHOW THE SCORE AFTER YOU HAVE CALCULATED IT , USING MAKE_SCORE
    }

    private int make_score()
    {
		int accusations = gameManager.failed_accusations;
		float time = timer.instance.getTime() ;
		int clues_not_found = 8 - gameManager.clues_found;
		int score = 100;
		score -= clues_not_found * 5;
		score -= accusations * 5;
		score -= Mathf.RoundToInt (time / 20);

        return score;
    }


	// Use this for initialization
	void Start () {
        
        fill_stats();    //REMOVE COMMENT TO FILL STATS ON THE SCREEN 
      
    }
	
	
}
