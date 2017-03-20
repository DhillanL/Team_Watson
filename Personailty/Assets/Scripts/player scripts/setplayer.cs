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
        
        if (gameman.istwoplayeron().Equals(true))          
        {
            if (gameman.getperson2().Equals(1))
            {
                GameObject.FindWithTag("bad2").tag = "Player2";
                Destroy(GameObject.FindWithTag("good2"));
                Destroy(GameObject.FindWithTag("susp2"));
                Destroy(GameObject.FindWithTag("trust2"));
                Destroy(GameObject.FindWithTag("smart2"));
                Destroy(GameObject.FindWithTag("dumb2"));

            } else if (gameman.getperson2().Equals(2))
            {
                GameObject.FindWithTag("good2").tag = "Player2";
                Destroy(GameObject.FindWithTag("bad2"));
                Destroy(GameObject.FindWithTag("susp2"));
                Destroy(GameObject.FindWithTag("trust2"));
                Destroy(GameObject.FindWithTag("smart2"));
                Destroy(GameObject.FindWithTag("dumb2"));
            } else if (gameman.getperson2().Equals(3))
            {
                GameObject.FindWithTag("smart2").tag = "Player2";
                Destroy(GameObject.FindWithTag("bad2"));
                Destroy(GameObject.FindWithTag("susp2"));
                Destroy(GameObject.FindWithTag("trust2"));
                Destroy(GameObject.FindWithTag("good2"));
                Destroy(GameObject.FindWithTag("dumb2"));
            } else if (gameman.getperson2().Equals(4))
            {
                GameObject.FindWithTag("dumb2").tag = "Player2";
                Destroy(GameObject.FindWithTag("bad2"));
                Destroy(GameObject.FindWithTag("susp2"));
                Destroy(GameObject.FindWithTag("trust2"));
                Destroy(GameObject.FindWithTag("good2"));
                Destroy(GameObject.FindWithTag("smart2"));
            } else if (gameman.getperson2().Equals(5))
            {
                GameObject.FindWithTag("trust2").tag = "Player2";
                Destroy(GameObject.FindWithTag("bad2"));
                Destroy(GameObject.FindWithTag("susp2"));
                Destroy(GameObject.FindWithTag("dumb2"));
                Destroy(GameObject.FindWithTag("good2"));
                Destroy(GameObject.FindWithTag("smart2"));
            } else
            {
                GameObject.FindWithTag("susp2").tag = "Player2";
                Destroy(GameObject.FindWithTag("bad2"));
                Destroy(GameObject.FindWithTag("trust2"));
                Destroy(GameObject.FindWithTag("dumb2"));
                Destroy(GameObject.FindWithTag("good2"));
                Destroy(GameObject.FindWithTag("smart2"));
            }
        } else
        {
            Destroy(GameObject.FindWithTag("bad2"));
            Destroy(GameObject.FindWithTag("trust2"));
            Destroy(GameObject.FindWithTag("dumb2"));
            Destroy(GameObject.FindWithTag("good2"));
            Destroy(GameObject.FindWithTag("smart2"));
            Destroy(GameObject.FindWithTag("susp2"));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
