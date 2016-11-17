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

    public void loadSprite(Sprite sprite)
    {
        Sprite = sprite;
    }

    public string getName()    // returns the name 
    {
        return Name;
    }

    public Sprite getSprite()
    {
        return Sprite;
    }


    public Personality_player getPersonality() // returns the personailty of the player 
    {
        return personailty;
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








   





    void Start () {
	
	}
	
	
	void Update () {
	
	}
}
