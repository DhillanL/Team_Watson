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
    

    public Text speachbox;
    public InputField interact_select;
    public Button confirm_interaction;
    public Button pick_question_type;

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

    

    public void set_interact()
    {
        clear_interact = true;
    }


    public void interact()                       // how the  player interacts with other things in the game, called when the player chose to interact   
    {
            if (interactions < 1)
            {
                
                speachbox.text = Personailty.Intro();       //if its his first interaction user will intoduce them selve
                interactions++;
            } else
            {
                speachbox.text = "how would you like to interact: \n1. Question \n2. Accuse";            // else ask how the user would like to interact 
                interact_select.transform.Translate(200, 0, 0);    // input box for choosing interaction 
                confirm_interaction.transform.Translate(200, 0, 0);  // confirm box --> when pressed call Question()
                interactions++;
            }
            
        
    }


    public void Question()
    {
        if (interact_select.text.Equals("1"))
        {
            speachbox.text = "select questioing method:\n1. " + Personailty.type1() + "\n2. " + Personailty.type2() + "\n3. " + Personailty.type3() ;
            interact_select.text = "";  // make input box empty
            confirm_interaction.transform.Translate(-200, 0, 0);   //move old button out of the way 
            pick_question_type.transform.Translate(200, 0, 0);     // bring in new button --> when presse call questiontype()
        }
        else
        {
            speachbox.text = ("no accuse yet");
        }
    }




    public void questiontype()
    {
        if (interact_select.text.Equals("1"))   
        {
            
            speachbox.text = Personailty.Question1();
            move_input_confirm_question_choice();      // call to move the boxes out of the way as input isnt needed. 
        }
        else if (interact_select.text.Equals("2"))
        {
            speachbox.text = Personailty.Question2();
            move_input_confirm_question_choice(); // call to move the boxes out of the way as input isnt needed. 
        }
        else
        {
            speachbox.text = Personailty.Question3();
            move_input_confirm_question_choice();
        }
    }

  
    public void move_input_confirm_question_choice()
    {
        pick_question_type.transform.Translate(-200, 0, 0);
        interact_select.transform.Translate(-200, 0, 0);

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
