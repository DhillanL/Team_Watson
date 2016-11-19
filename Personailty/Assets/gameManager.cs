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

    public GameObject room11;
    public GameObject room12;
    public GameObject room21;


    //public GameObject[] roomlst = { Room11, Room12, Room21 };

    // UI elements --> USED IN THE PLAYER SLECTION MENU
    public Button finish_playerSelect;                 // button finish for player select screen 






    
    // Accessors and mutators for attributes 

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

    public void populateroom1()
    {
       GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(300,0,0);
       GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400,0,0);
    }

    public void populateroom2()
    {
        GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(-300, 0, 0);
        GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(-400, 0, 0);
        GameObject.FindWithTag(room21.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);

    }


   

    // FUNCTIONs TO MOVE BETWEEN SCENES 

    public void player_select_finish()   // 1. used in the player selection scene when the user hits the finish button 
    {
        SceneManager.LoadScene("Screen2");
        
    }

    public void load_player_select()
    {
        SceneManager.LoadScene("test1");     // load the player selection scene
    }


    public void load_scence_3()   // 1. used in the player selection scene when the user hits the finish button 
    {
        SceneManager.LoadScene("Screen3");
        populateroom2();

    }











    void Start () {
	    
	}
	
	
	void Update () {
	
	}
}
