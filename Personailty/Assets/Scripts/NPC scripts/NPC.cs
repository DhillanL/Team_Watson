using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    // Abstract class which is used to create all of the NPC's in the game. They will all be created from this class. 
    // The details are also used in the crime creation so that the details are correct for he victim EG: he/she  

    // below are all attributes for the NPC class
    public Sprite look;    //sprite used for their avlie look 
    public Sprite headshot; // the sprite used for the head shot 

    public string Name;
    public string initial;
    public int age;
	private int num_of_clues;

	public bool hasVerbalClue = false;

    public string he_she;
    public string man_woman;

    public string room;
   
    public bool is_muderer = false;
    public bool is_accused = false;
    public bool is_victim = false;

    public bool first_interaction = true;
    public bool okay_to_interact = true;

    public string clue;
    public clue clue_object;

    public string intro;

    public string dont_interact_response;
    public bool acuuse_wrong = false;

    public string clue_response1;
    public string clue_response2; 

    public string dont_interact_if1 = "";    // string is set to empty to start 
    public string dont_interact_if2 = "";    // these are used to test against after an NPC has resposned to see if they wil talk again 
    public string dont_interact_if3 = "";    // these are set to the responses that the npc would say if they dont want to talk anymore. EG: NPC may say 'thats horrible dont talk to me again'
                                             // this may be there response if they are questioned aggresively. so we can test if they are the same and change okay_to_interact to false;
    public string incorect_accusation;

    public int orintation = 1;
        
    //respsones
    public string aggressive_response; 
    public string violent_response; 
    public string threaten_response; 
    public string kind_response; 
	public string sympthetic_response; 
    public string friendly_response; 
    public string cunning_response;
    public string mean_response;

    Vector3 newPos = new Vector3(-300,-21,0);   // starting pos for all of the NPCS

    public GameObject Interaction;  // used to find the interaction scirpt for each scene 
    public GameObject me;


    public void isMurder()
    {
        is_muderer = true;
    }


    public void is_Victim()
    {
        is_victim = true;
    }


    public void reset_pos()
    {
        transform.position = newPos;
    }


    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// no of clues found at last interaction. -- faceless drones additon
	public void StoreNumOfClues(int num)
	{
		num_of_clues = num;
	}

	// no of clues found at last interaction. -- faceless drones additon
	public int GetNumOfClues()
	{
		return num_of_clues;
	}


    void OnMouseDown()  // when the NPC is clicked on 
    {
        Interaction = GameObject.FindWithTag("interaction"); 
        if (Interaction.GetComponent<Interaction>().npc == null)                      // make sure there is no other interaction currently underway
        {
            Interaction.GetComponent<Interaction>().setNPC(me.GetComponent<NPC>());   // sets the npc who is being comuncated with in the gameman
            Interaction.GetComponent<Interaction>().setNPCobj(me);                    // set the game object
                                                                
            Interaction.GetComponent<Interaction>().pick_interaction();               // starts the interaction - call the interaction class 
        }
        else
        {
            Debug.Log("finish current interaction");   // apperars if you are already in a conversation with someone.  
        }
    }


}
