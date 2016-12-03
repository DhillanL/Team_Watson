using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    static public bool spwaned = false;


    public string Name;                       // name of the player 
    public Personality_player Personailty ;   //personailty of the player 
    public Sprite Sprite;                     //look of the player


    public GameObject gameMan;
    private gameManager data;  //data from the gamemanager script 

    public GameObject Player;    //reference the player so we can change the look 
    

    public int interactions;

    public bool clear_interact = false;

    public float speed = 70f;
    private Rigidbody2D rb2D; 


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
        if (gameMan.GetComponent<gameManager>().get_player_set())
        {
            ;
        }
        else
        {
            setPlay();
            rb2D = GetComponent<Rigidbody2D>(); // gets the ridig body of the player 
            gameMan.GetComponent<gameManager>().set_player_to_true();

        }
        
    }

    
    void Update()      // making the player move. A goes left, D goes right 
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb2D.velocity = new Vector2(-speed, 0);
            
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rb2D.velocity = new Vector2(0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb2D.velocity = new Vector2(speed, 0);

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rb2D.velocity = new Vector2(0, 0);
        }


    }



}
