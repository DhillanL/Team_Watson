using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class turnswitcher : MonoBehaviour {

    public bool playing = true;
    public bool player1turn = true;

    public bool in_puzzle = false;
 


    IEnumerator Gameloop()  // main game loop for the turn based game
    {
        while(playing)
        {

            yield return new WaitForSeconds(30);
            if (in_puzzle)
            {
                ;

            } else
            {
                StartCoroutine(swapplayer());
            }
            
            
        }
        
    }

    IEnumerator swapplayer()  // player switching corotine 
    {
        GameObject.FindWithTag("Player").GetComponent<player>().set_vel_0(); // stops the playe if they are already moving 
        GameObject.FindWithTag("Player").GetComponent<player>().walkF();  // stops the player walking 
        
        switchplayertags();  // switch the tags of the players 
        
        GameObject.FindWithTag("swap").GetComponent<Transform>().position = new Vector3(5, 4, 0);  // shows the switch player screens 
        yield return new WaitForSeconds(5);  // wait 5 seconds 
        GameObject.FindWithTag("swap").GetComponent<Transform>().position = new Vector3(4, 200, 0);

        GameObject.FindWithTag("Player").GetComponent<Transform>().position = GameObject.FindWithTag("Player2").GetComponent<Transform>().position;
        GameObject.FindWithTag("Player2").GetComponent<Transform>().position = new Vector3(0, -200, 0);

        GameObject.FindWithTag("ID").GetComponent<showid>().swap_ID();
        GameObject.FindWithTag("Player").GetComponent<player>().walkT();
        loadroom();
        
    }



    private void switchplayertags()  // switch the tags of the player 
    {
        GameObject.FindWithTag("Player").tag = "tempplayer";
        GameObject.FindWithTag("Player2").tag = "Player";
        GameObject.FindWithTag("tempplayer").tag = "Player2";
        gameManager gameman = GameObject.FindWithTag("gamemanager").GetComponent<gameManager>();
        gameman.swap_players();  // swap the id for who is playing in the game manager 

    }

    private void loadroom()  // loads the last room that the player was in  
    {
        gameManager gameman = GameObject.FindWithTag("gamemanager").GetComponent<gameManager>();
        string room = GameObject.FindWithTag("Player").GetComponent<player>().PastScene;
        if (room == "Room3")
        {
            gameman.load_meetingroom();
        }
        else if (room == "Room4")
        {
            gameman.load_kitchen();
        }
        else if (room == "Room5")
        {
            gameman.load_lakehousebalcony();
        }
        else if (room == "Room6")
        {
            gameman.load_outside_lakes();
        }
        else if (room == "Room7")
        {
            gameman.load_upstairslecture();
        }
        else if (room == "Room8")
        {
            gameman.load_outside_bottombalcony();
        } else if (room == "screen2")
        {
            gameman.load_RCH1();
        } else if (room == "Screen3")
        {
            gameman.load_RCH2();
        }
    }

    public void startGameloopcorotine()
    {
        StartCoroutine(Gameloop());
    }

    public void stop_loop()
    {
        in_puzzle = true;
    }

    public void start_loop()
    {
        in_puzzle = false;
    }


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
