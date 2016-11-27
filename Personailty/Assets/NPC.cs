using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public Sprite look;    //sprite used for picture

    public string Name;
   
    public bool is_muderer = false;
    public bool is_accused = false;
    public bool is_victim = false;

    public bool first_interaction = true;
    public bool okay_to_interact = true;

    public string clue;

    public string intro;

    public string dont_interact_response;

    public string dont_interact_if1 = "";    // string is set to empty to start 
    public string dont_interact_if2 = "";    // these are used to test against after an NPC has resposned to see if they wil talk again 
    public string dont_interact_if3 = "";    // these are set to the responses that the npc would say if they dont want to talk anymore. EG: NPC may say 'thats horrible dont talk to me again'
                                             // this may be there response if they are questioned aggresively. so we can test if they are the same and change okay_to_interact to false;
    //BadCop
    public string aggressive_response;
    public string violent_response;
    public string threaten_response;
	public string arrogant_response;
	public string indifferent_response;

    //GoodCop
    public string kind_response;
    public string symethic_response;
    public string friendly_response;
	public string humorous_response;
	public string enthusiastic_response;


    Vector3 newPos = new Vector3(-300,-12,0);   // starting pos for all of the NPCS

    public GameObject Interaction;
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
