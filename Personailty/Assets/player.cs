using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

   

    public string Name;                       // name of the player 
    public Personality_player Personailty ;   //personailty of the player 
    public Sprite Sprite;                     //look of the player


    public GameObject gameMan;
    private gameManager data;  //data from the gamemanager script 

    public GameObject Player;    //reference the player so we can change the look 
    

    public int interactions;

    public bool clear_interact = false;


    public void setPlay()    // sets the name personailty Aand the sprite for the player 
    {
        data = gameMan.GetComponent<gameManager>();
        Name = data.getName();
        Personailty = data.getPersonality();
        Sprite = data.getSprite();
        Player.GetComponent<SpriteRenderer>().sprite = Sprite;
    }

    




    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }





    void Start()
    {
        setPlay();   //when the Chacrter is created set the name and personailty as seleted by user 
    }

    
    void Update()
    {
        
        
        
    }



}
