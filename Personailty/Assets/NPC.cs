using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public Sprite look;    //sprite used for their avlie look 
    public Sprite headshot; // the sprite used for the head shot 

    public string Name;
    public string initial;
    public int age;

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

    public string clue_response1;
    public string clue_response2; 

    public string dont_interact_if1 = "";    // string is set to empty to start 
    public string dont_interact_if2 = "";    // these are used to test against after an NPC has resposned to see if they wil talk again 
    public string dont_interact_if3 = "";    // these are set to the responses that the npc would say if they dont want to talk anymore. EG: NPC may say 'thats horrible dont talk to me again'
                                             // this may be there response if they are questioned aggresively. so we can test if they are the same and change okay_to_interact to false;
    public string incorect_accusation;

    public int orintation = 1;
        
    //respsones
    public string aggressive_response; //
    public string violent_response; //
    public string threaten_response; //
    public string kind_response; //
	public string sympthetic_response; //
    public string friendly_response; //
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





    void OnMouseDown()
    {
        Interaction = GameObject.FindWithTag("interaction"); 
        if (Interaction.GetComponent<Interaction>().npc == null)
        {
            Interaction.GetComponent<Interaction>().setNPC(me.GetComponent<NPC>());   // sets the npc who is being comuncated with in the gameman
            Interaction.GetComponent<Interaction>().setNPCobj(me); // set the game object
                                                                
            Interaction.GetComponent<Interaction>().pick_interaction();               // starts the interaction
        }
        else
        {
            Debug.Log("finish current interaction");
        }
    }









    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
