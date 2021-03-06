﻿// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour {

    // Interaction class is attached to a interaction game object in every scene. This is called whenever the player clicks onto one of the NPC's to start the interaction with them


    // game object variables that are set the objects in that scene  
    public GameObject Player;
    public GameObject gameman;
    public GameObject logbookpart;
    public GameObject npcobj;
    public gameManager Gamemanager;
    public player player;
    public NPC npc;         // who the playe is currently interacting with

    public Text speachbox ;                // The speach box 

    public Button question;          // Where the player can input their choices
    public Button accusebutt;      // accuse button 
	public Button ignorebutt;   		//Ignore Button  
    public Button questioingtype1;
    public Button questioingtype2;
    public Button questioingtype3;

    public GameObject head_shot;   // the head shot for the NPC the player is talking to 

  
    public string question_style_text;

    static public int incorrect_aac_num = 0;   // the number of inncorrect gusses. only get one attempt to guess (could be replaced with a boolen) 

    public void increase_acc_num()
    {
        incorrect_aac_num++;
    }


    public void setNPC(NPC npcin)  // set the current interaction to the NPC the player is talking to.
    {
        npc = npcin;

    }

    public void setNPCobj(GameObject npcob)
    {
        npcobj = npcob;
    }
 
	public string npc_response()   // function to be able to select the correct response from the NPC
	{
		switch(question_style_text)
		{
		case "Aggressive":
			return (npc.aggressive_response);
		
		case "Violent":
			return (npc.violent_response);
			
		case "Threaten":
                return (npc.threaten_response);
			
		case "Kind":
			return (npc.kind_response);
			
		case "Friendly":
			return (npc.friendly_response);
			
		case "Cunning":
			return (npc.cunning_response);
			
		case "Mean":
			return (npc.mean_response);
			
		default:
			return (npc.sympthetic_response);
			
		}
	}

    public void set_orintation() // set the direction that the NPC is looking at to be at the player 
    {
        if (player.orintation == npc.orintation)
        {
            if (npc.orintation == 1 )
            {
                npcobj.GetComponent<SpriteRenderer>().flipX = true;
                npc.orintation = 0;
            } else
            {
                npc.orintation = 1;
                npcobj.GetComponent<SpriteRenderer>().flipX = false;
            }
        }

    }


    public void pick_interaction(int id)   // function whihc runs all of interaction 
    {

        Player = GameObject.FindWithTag("Player");          // sets up the player and in the interaction class for each scene 
        player = Player.GetComponent<player>();
        if (npc.is_victim == true)    // if the victim's body - give descitption 
        {

            speachbox.text = "R.I.P";
            npc = null;

        }
        else
        {
            if (id == 1)
            {
                head_shot.GetComponent<SpriteRenderer>().sprite = npc.headshot;  // get teh headshot to put into the GUI

                set_orintation();  // set the NPC to face the player 

                if (npc.first_interactionid1 == true)   /// if its the players first interaction wiht the NPC
                {
                    speachbox.text = "Detective " + player.Name + " :  " + player.Personailty.intro;   // dispaly introduction for the NPC

                    speachbox.text = speachbox.text + "\n\n" + npc.Name + ": " + npc.intro;

                    npc.first_interactionid1 = false;   // set first interaction to false 

                    npc = null;
                }
                else
                {

                    speachbox.text = "How would you like to interact:";
                    question.transform.Translate(0, 57, 0);   // bring up the three buttons to the screen so the player can pick to QUESTION, ACCUSE or IGNORE
                    accusebutt.transform.Translate(0, 57, 0);
                    ignorebutt.transform.Translate(0, 57, 0);
                }

            } else if (id == 2)
            {
                head_shot.GetComponent<SpriteRenderer>().sprite = npc.headshot;  // get teh headshot to put into the GUI

                set_orintation();  // set the NPC to face the player 

                if (npc.first_interactionid2 == true)   /// if its the players first interaction wiht the NPC
                {
                    speachbox.text = "Detective " + player.Name + " :  " + player.Personailty.intro;   // dispaly introduction for the NPC

                    speachbox.text = speachbox.text + "\n\n" + npc.Name + ": " + npc.intro;

                    npc.first_interactionid2 = false;   // set first interaction to false 

                    npc = null;
                }
                else
                {

                    speachbox.text = "How would you like to interact:";
                    question.transform.Translate(0, 57, 0);   // bring up the three buttons to the screen so the player can pick to QUESTION, ACCUSE or IGNORE
                    accusebutt.transform.Translate(0, 57, 0);
                    ignorebutt.transform.Translate(0, 57, 0);
                }
            }
              

            }

        } 
        
    


    public void pick_question()  // if the player slectes the question button 
    {
		
		NewClueObtainedCheck (); //Checks that is the character has been ignored, and if player has collected a new clue since last ignoring them or not. 
		if ((npc.okay_to_interact == true) && (npc.acuuse_wrong == false)) // test that its okay to interact with the NPC EG: they have told you to go away second tests if you have got a new clue since speaking to them 
        {
            question.transform.Translate(0, -57, 0);
            accusebutt.transform.Translate(0, -57, 0);
			ignorebutt.transform.Translate (0, -57, 0);
            questioingtype1.transform.Translate(0, 57, 0);  // bring up the three buttons so they can pick which interaction type they want to select 
            questioingtype2.transform.Translate(0, 57, 0);
            questioingtype3.transform.Translate(0, 57, 0);
            questioingtype1.GetComponentInChildren<Text>().text = player.Personailty.type1();
            questioingtype2.GetComponentInChildren<Text>().text = player.Personailty.type2();
            questioingtype3.GetComponentInChildren<Text>().text = player.Personailty.type3();
        } else
        {
            question.transform.Translate(0, -57, 0);
            accusebutt.transform.Translate(0, -57, 0);
			ignorebutt.transform.Translate (0, -57, 0);
            speachbox.text = npc.name + ": " + npc.dont_interact_response;  // dont interact response 
            npc = null;
        }

    }

	//____NEW___ADDITION_____
	public void NewClueObtainedCheck(){		//Made public for testing periods
		if ((logbookparts.clue_count1 - npc.GetNumOfClues ()) > 0) { //Check number of clues obtained since last speaking to this character is at least one
			npc.okay_to_interact = true;
		} 
	}

	
    public void ignore()   // function to be called when the ignore button is pressed
	{
		//Move UI Elements out of scene view
		question.transform.Translate(0, -57, 0);
		accusebutt.transform.Translate(0, -57, 0);
		ignorebutt.transform.Translate (0, -57, 0);
		speachbox.text = ""; 									//Show no text in speech box
		head_shot.GetComponent<SpriteRenderer>().sprite = null; //Replace headshot image with no image 							
		npc.StoreNumOfClues(logbookparts.clue_count1);
		npc.okay_to_interact = false;							//Can't interact with npc again
		npc = null;												//Update npc to reflect that there is no npc selected
	}


    public void questioing_style1()  // if the user picks their first interaction style
	{
        
        move_boxes ();
		question_style_text = player.Personailty.questiontype1;
		speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question1 ();

		if (npc.clue != "") {
			if (((npc.clue_object.is_motive == true)&&(gameManager.clues_found > 1)) || (question_style_text.Equals (npc.clue_response1) || question_style_text.Equals (npc.clue_response2))) {
				speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
				logbookpart.GetComponent<logbookparts> ().add_clue (npc.clue_object);  // add the clue to the log book if they give a clue 
				check_okay_to_interact (npc);
				npc = null;  // set interactin to clear after it is finished
			} else {
				speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
				check_okay_to_interact(npc);
				npc = null;
			}
		} else {
			speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
			check_okay_to_interact(npc);
			npc = null;
		}
	}
    



    public void questioing_style2()  // if the user selects the second interaction method
        {

            move_boxes();
            question_style_text = player.Personailty.questiontype2;
            speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question2();

		if (npc.clue != "") {
			if (((npc.clue_object.is_motive == true)&&(gameManager.clues_found > 1)) || (question_style_text.Equals (npc.clue_response1) || question_style_text.Equals (npc.clue_response2))) {
				speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
				logbookpart.GetComponent<logbookparts> ().add_clue (npc.clue_object);  // add the clue to the log book if they give a clue 
				check_okay_to_interact (npc);
				npc = null;  // set interactin to clear after it is finished
			} else {
				speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
				check_okay_to_interact(npc);
				npc = null;
			}
		} else {
			speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
			check_okay_to_interact(npc);
			npc = null;
		}
	}

    public void questioning_style3()  // if the player selects the third interaction type 
    {
            move_boxes();
            question_style_text = player.Personailty.questiontype3;
            speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question3();

		if (npc.clue != "") {
			if (((npc.clue_object.is_motive == true)&&(gameManager.clues_found > 1)) || (question_style_text.Equals (npc.clue_response1) || question_style_text.Equals (npc.clue_response2))) {
				speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
				logbookpart.GetComponent<logbookparts> ().add_clue (npc.clue_object);  // add the clue to the log book if they give a clue 
				check_okay_to_interact (npc);
				npc = null;  // set interactin to clear after it is finished
			} else {
				speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
				check_okay_to_interact(npc);
				npc = null;
			}
		} else {
			speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
			check_okay_to_interact(npc);
			npc = null;
		}
	}

    public void move_boxes()  // used to move the three question type boxes off the screen 
    {
        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
    }


    public void check_okay_to_interact(NPC npc)  // check that the player is okay to interact with the NPC - will not be if tey npc has told them to go away 
    {
        if (npc_response().Equals(npc.dont_interact_if1) || npc_response().Equals(npc.dont_interact_if2) || npc_response().Equals(npc.dont_interact_if3))
        {
            npc.okay_to_interact = false;
        }
        else
        {
            npc.okay_to_interact = true;
        }
    }


             

    public void accuse()  // if the plyer selects te accuse button 
    {
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
		ignorebutt.transform.Translate (0, -57, 0);
        if (gameManager.clues_found < 3)
        {
            speachbox.text = "You need to have found at least three physical clues before you can accuse soemone! \n\n You must be new to detective work";
            npc = null;
			gameManager.failed_accusations++;
        } else
        {
            if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1)
            {
                

                    if (npc.Name == Gamemanager.get_murder())  // IF THE PLAYER ACCUSES THE MURDERER
                    {
                        Debug.Log("YOU WIN");
                        destory_objects();
                        reset_newgame();
                        npc = null;
                        SceneManager.LoadScene("win");

                    }
                    else
                    {  // IF THE PLAYER DOES NOT ACCUSE THE CORRECT NPC
                        gameManager.failed_accusations++;
                        speachbox.text = npc.incorect_accusation;
                        increase_acc_num();
                        Debug.Log(incorrect_aac_num);
                        npc.acuuse_wrong = true;
                        npc = null;
                        if (gameManager.failed_accusations > 1)
                        {
                            Debug.Log("GAME OVER");
                            destory_objects();
                            reset_newgame();
                            npc = null;
                            SceneManager.LoadScene("lose");  // load the losing screen 
                        }
                    }
                

            } else
            {
               

                    if (npc.Name == Gamemanager.get_murder())  // IF THE PLAYER ACCUSES THE MURDERER
                    {
                        Debug.Log("YOU WIN");
                        destory_objects();
                        reset_newgame();
                        npc = null;
                        SceneManager.LoadScene("win");

                    }
                    else
                    {  // IF THE PLAYER DOES NOT ACCUSE THE CORRECT NPC
                        gameManager.failed_accusationpplayer2++;
                        speachbox.text = npc.incorect_accusation;
                        increase_acc_num();
                        Debug.Log(incorrect_aac_num);
                        npc.acuuse_wrong = true;
                        npc = null;
                        if (gameManager.failed_accusationpplayer2 > 1)
                        {
                            Debug.Log("GAME OVER");
                            destory_objects();
                            reset_newgame();
                            npc = null;
                            SceneManager.LoadScene("lose");  // load the losing screen 
                        }
                    }
                
            }
            
        }

    }

    public void reset_newgame() // called when starting a new game 
    {
        incorrect_aac_num = 0;
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().reset_clues();
    }



    public void destory_objects()  // desoty all the objects when loaded the final screen 
    {
        string[] objects = {"Player", "Bernard", "Tonald", "George", "Ethan", "Ryan", "Zoe", "Alice", "Stephen",
        "Robert", "Sophie", "Clue1", "Clue2", "Clue3", "Clue4", "Clue5", "Clue6", "Clue7", "Clue8", "map", "map_icon",
        "log_button","logbook","logbookcrime","GUI",};
        for (int i = 0; i < 25; i++)
        {
            Destroy(GameObject.FindWithTag(objects[i]));
        }


    }


    // Use this for initialization
    void Start () {
        Player = GameObject.FindWithTag("Player");          // sets up the player and in the interaction class for each scene 
        player = Player.GetComponent<player>();            
        gameman = GameObject.FindWithTag("gamemanager");   // sets the game manger to be used for interaction when each scene is loadede
        Gamemanager = gameman.GetComponent<gameManager>();
	}
	
	
}
