using UnityEngine;
using System.Collections;

public class setplayer : MonoBehaviour {

    // sets the player to what personality that they select on the selections screen

    public GameObject gamemanager;
    gameManager gameman;

	// Use this for initialization
	void Start () {
        gameman = gamemanager.GetComponent<gameManager>();
        if (gameman.getpersonint().Equals(1))
        {
            GameObject.FindWithTag("player_bad").tag = "Player";
            Destroy(GameObject.FindWithTag("player_good"));
            Destroy(GameObject.FindWithTag("player_susp"));
            Destroy(GameObject.FindWithTag("player_trust"));
            Destroy(GameObject.FindWithTag("player_smart"));
            Destroy(GameObject.FindWithTag("player_dumb"));

        } else if (gameman.getpersonint().Equals(2))
        {
            GameObject.FindWithTag("player_good").tag = "Player";
            Destroy(GameObject.FindWithTag("player_bad"));
            Destroy(GameObject.FindWithTag("player_susp"));
            Destroy(GameObject.FindWithTag("player_trust"));
            Destroy(GameObject.FindWithTag("player_smart"));
            Destroy(GameObject.FindWithTag("player_dumb"));

        } else if (gameman.getpersonint().Equals(3))
        {
            GameObject.FindWithTag("player_smart").tag = "Player";
            Destroy(GameObject.FindWithTag("player_bad"));
            Destroy(GameObject.FindWithTag("player_susp"));
            Destroy(GameObject.FindWithTag("player_trust"));
            Destroy(GameObject.FindWithTag("player_good"));
            Destroy(GameObject.FindWithTag("player_dumb"));
        }
        else if (gameman.getpersonint().Equals(4))
        {
            GameObject.FindWithTag("player_dumb").tag = "Player";
            Destroy(GameObject.FindWithTag("player_bad"));
            Destroy(GameObject.FindWithTag("player_susp"));
            Destroy(GameObject.FindWithTag("player_trust"));
            Destroy(GameObject.FindWithTag("player_smart"));
            Destroy(GameObject.FindWithTag("player_good"));
        }
        else if (gameman.getpersonint().Equals(5))
        {
            GameObject.FindWithTag("player_trust").tag = "Player";
            Destroy(GameObject.FindWithTag("player_bad"));
            Destroy(GameObject.FindWithTag("player_susp"));
            Destroy(GameObject.FindWithTag("player_good"));
            Destroy(GameObject.FindWithTag("player_smart"));
            Destroy(GameObject.FindWithTag("player_dumb"));
        }
        else if (gameman.getpersonint().Equals(6))
        {
            GameObject.FindWithTag("player_susp").tag = "Player";
            Destroy(GameObject.FindWithTag("player_bad"));
            Destroy(GameObject.FindWithTag("player_good"));
            Destroy(GameObject.FindWithTag("player_trust"));
            Destroy(GameObject.FindWithTag("player_smart"));
            Destroy(GameObject.FindWithTag("player_dumb"));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
