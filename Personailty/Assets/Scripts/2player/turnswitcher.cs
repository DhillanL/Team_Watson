//  WHOLE SCRIPT IS NEW FOR ASSESSEMNT 4.
// THE TURN SWITCHER IS USED TO RUN THE PROCEDURE TO ENSURE THAT TEH SWITCHER OF THE PLAYER WORKS WELL AND IS DONE CORRECTLTY.
// WANT BOTH OF THEM TO HAVE THEIR OWN LOG BOOKS ADN NO INFORAMTION IS LOST BETWEEN THEM. 
// ALL OF THE COROUTINES PROVIDE THAT FUNCTIONALITY
// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class turnswitcher : MonoBehaviour {

    public bool playing = true;
    public bool player1turn = true;

    public bool in_puzzle = false;

    public bool gamefinished = false;

    public int turn_length = 30; // int is used to set the length of a turn for each player 
 


    IEnumerator Gameloop()  // main game loop for the turn based PART FO THE GAME
    {
        while(playing) // WHILE TH GAME IS RUNNING (there is no winner)
        {

            yield return new WaitForSeconds(turn_length);  // this provided procedure determine the turn length by waiting for that many seconds before performing a switch  
            if (in_puzzle)
            {
                ;  // if tyou are in the puzzle do not switch players, we have done this as it didnt work well in gameplay tests 

            } else
            {
                StartCoroutine(swapplayer());   //once the turn is call the switch players coroutine.  
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
        moveoffscreen(GameObject.FindWithTag("Player2"));
        //GameObject.FindWithTag("Player2").GetComponent<Transform>().position = new Vector3(0, -200, 0);

        GameObject.FindWithTag("ID").GetComponent<showid>().swap_ID();
        GameObject.FindWithTag("Player").GetComponent<player>().walkT();
        loadroom();  // loads the last room that the players were in 
        
    }


    public void moveoffscreen(GameObject player)
    {
        player.GetComponent<Transform>().position = new Vector3(0, -200, 0);
    }


    private void switchplayertags()  // switch the tags of the player 
    {
        swaptags();
        gameManager gameman = GameObject.FindWithTag("gamemanager").GetComponent<gameManager>();
        gameman.swap_players();  // swap the id for who is playing in the game manager 

    }

    public void swaptags() // swpas the tags of the players 
    {
        GameObject.FindWithTag("Player").tag = "tempplayer";
        GameObject.FindWithTag("Player2").tag = "Player";
        GameObject.FindWithTag("tempplayer").tag = "Player2";
    }

    private void loadroom()  // loads the last room that the player was in  
    {
        gameManager gameman = GameObject.FindWithTag("gamemanager").GetComponent<gameManager>();
        string room = GameObject.FindWithTag("Player").GetComponent<player>().PastScene;
        Debug.Log(room);
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
        } else if (room == "Screen2")
        {
            gameman.load_RCH1();
        } else if (room == "Screen3")
        {
            gameman.load_RCH2();
        }
    }

    public void startGameloopcorotine()  // called to start the game turn loop. Called after the case file scene. 
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

    public void stop_playing() // once there is a winning swap the players 
    {
        playing = false;
    }

     
    
}
