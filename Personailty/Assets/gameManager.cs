using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// gameManager is a script that will be atatched to an object called GameManager that should be created on ever scene 
// it wil hold relevant data needed throughout the game through the use of static variables 
// can only be changed through accessors and mutators 

//used to load scences as well 

public class gameManager : MonoBehaviour {

    // PLAYER attributes
    static public string Name;                         // players name 
    static public Personality_player personailty;      // players pesonailty 
    static public Sprite Sprite;                       // players look 

    static public NPC murderer;      // murderer
    static public NPC victim;        // victim 

    public NPC current_interaction;


    // NPC GAMEOBJECTS AND LOCATIONS
    static public GameObject room11;
    static public GameObject room12;
    static public GameObject room21;
    static public GameObject room31;
    static public GameObject room41;
    static public GameObject room51;
    static public GameObject room61;
    static public GameObject room71;
    static public GameObject room72;
    static public GameObject room81;

    // CLUE ROOM LOCATIONS  
	static public GameObject room1;
	static public GameObject room2;
	static public GameObject room3;
	static public GameObject room4;
	static public GameObject room5;
	static public GameObject room6;
	static public GameObject room7;
	static public GameObject room8;



    // UI elements --> USED IN THE PLAYER SLECTION MENU
    public Button finish_playerSelect;                 // button finish for player select screen 

    public GameObject create_npcs;


    public Camera maincamera;
    public Canvas canvas;


    
    // Accessors and mutators for attributes for the player  

    public void loadName(string namein) //FUNCTION TO A CHANGE THE VALUE OF NAME 
    {
        Name = namein;
    }


    public void loadPersonailty(Personality_player personal) //FUNCTION TO CHANGE THE VALUE OF PESONAILTY
    {
        personailty = personal;
    }

    public void loadSprite(Sprite sprite)   // load the sprite
    {
        Sprite = sprite;
    }

    public string getName()    // returns the name 
    {
        return Name;
    }

    public Sprite getSprite()  // returns the sprite
    {
        return Sprite;
    }


    public Personality_player getPersonality() // returns the personailty of the player 
    {
        return personailty;
    }


    // FUNCTIONS TO SET THE MURDERER FOR THE GAME AND THE VICTIM 

    public void set_murder(NPC npc)
    {
        murderer = npc;
    }
    public string get_murder()
    {
        return murderer.Name;
    }


    public void set_victim(NPC npc)
    {
        victim = npc;
    }
    public string get_victim()
    {
        return victim.Name; ;
    }

	//methods for setting the rooms for the clues
	public void setClue1(GameObject clue){
		room1 = clue;
	}
	public void setClue2(GameObject clue){
		room2 = clue;
	}
	public void setClue3(GameObject clue){
		room3 = clue;
	}
	public void setClue4(GameObject clue){
		room4 = clue;
	}
	public void setClue5(GameObject clue){
		room5 = clue;
	}
	public void setClue6(GameObject clue){
		room6 = clue;
	}
	public void setClue7(GameObject clue){
		room7 = clue;
	}
	public void setClue8(GameObject clue){
		room8 = clue;
	}

    //methods for setting the players in the room in pos

    public void setroom11(GameObject npc)
    {
        room11 = npc;
    }
    public void setroom12(GameObject npc)
    {
        room12 = npc;
    }
    public void setroom21(GameObject npc)
    {
        room21 = npc;
    }
    public void setroom31(GameObject npc)
    {
        room31 = npc;
    }
    public void setroom41(GameObject npc)
    {
        room41 = npc;
    }
    public void setroom51(GameObject npc)
    {
        room51 = npc;
    }
    public void setroom61(GameObject npc)
    {
        room61 = npc;
    }
    public void setroom71(GameObject npc)
    {
        room71 = npc;
    }
    public void setroom72(GameObject npc)
    {
        room72 = npc;
    }
    public void setroom81(GameObject npc)
    {
        room81 = npc;
    }


    public void reset_npc_pos()    // will return all npcs back to starting pos. 
    {
        GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room21.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room31.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room41.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room51.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room61.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room71.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room72.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room81.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
    }


    // FUNCTIONS TO POPULATE THE ROOMS WITH THE NPCS

    public void populateroom1()
    {
       reset_npc_pos();
       GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(300,0,0);   //each npc has a tag which is their name making them easier to find 
       GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400,0,0);

    }

    public void populateroom2()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room21.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
    }

    public void populateroom3()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room31.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 30, 0);
    }

    public void populateroom4()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room41.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
    }

    public void populateroom5()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room51.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
    }

    public void populateroom6()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room61.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
    }

    public void populateroom7()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room71.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        GameObject.FindWithTag(room72.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(300, 0, 0);
    }

    public void populateroom8()
    {
        reset_npc_pos();
        GameObject.FindWithTag(room81.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
    }
   


    // FUNCTIONs TO MOVE BETWEEN SCENES 


    public void load_player_select()
    {
        SceneManager.LoadScene("test1");     // load the player selection scene
    }

    public void player_select_finish()   // 1. used in the player selection scene when the user hits the finish button 
    { // loads room 1 
        SceneManager.LoadScene("Screen2");
        populateroom1();

    }

    public void load_room2()   // 1. used in the player selection scene when the user hits the finish button 
    {  // loads rooom 2 
        SceneManager.LoadScene("Screen3");
        populateroom2();
    }

    public void load_room3()  //load room 3 
    {
        SceneManager.LoadScene("Room3");
        populateroom3();
    }

    public void load_room4()
    {
        SceneManager.LoadScene("Room4");
        populateroom4();
    }

    public void load_room5()
    {
        SceneManager.LoadScene("Room5");
        populateroom5();
    }

    public void load_room6()
    {
        SceneManager.LoadScene("Room6");
        populateroom6();
    }

    public void load_room7()
    {
        SceneManager.LoadScene("Room7");
        populateroom7();
    }

    public void load_room8()
    {
        SceneManager.LoadScene("Room8");
        populateroom8();
    }

    

    // for testing 



    void Start () {
        Debug.Log("Room1.1 = " + room11);    // so we can see who is in the rooms for testing 
        Debug.Log("Room1.2 = " + room12);
        Debug.Log("Room2.1 = " + room21);
        Debug.Log("Room3.1 = " + room31);
        Debug.Log("Room4.1 = " + room41);
        Debug.Log("Room5.1 = " + room51);
        Debug.Log("Room6.1 = " + room61);
        Debug.Log("Room7.1 = " + room71);
        Debug.Log("Room7.2 = " + room72);
        Debug.Log("Room8.1 = " + room81);

    }
	
	
	void Update () {
	
	}
}
