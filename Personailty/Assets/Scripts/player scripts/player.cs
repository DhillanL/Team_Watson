using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    // The playe class 

    static public bool spwaned = false;

    public Text speach_box;

    public string Name;                       // name of the player 
    public Personality_player Personailty ;   //personailty of the player 
    public Sprite Sprite;                     //look of the player
    public int personint;
    Animator anim;    // the walking anaimtion for the player 


    public GameObject gameMan;
    private gameManager data;  //data from the gamemanager script 

    public GameObject Player;    //reference the player so we can change the look 
    

    public int interactions;

    public bool clear_interact = false;

    public float speed = 70f;   //speed that the player moves at across the screen 
    private Rigidbody2D rb2D; // the rigid body for the player 


    public bool walk = true;


    public void setPlay()    // sets the name personailty Aand the sprite for the player 
    {
        data = gameMan.GetComponent<gameManager>();
        Name = data.getName();
        Personailty = data.getPersonality();
        personint = data.getpersonint();
      
    }

    public void walkT() // player is allowed to walk 
    {
        walk = true;
    }

    public void walkF()  // means the playe can't walk
    {
        walk = false ;
    }


    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    void Start()
    {
    
            setPlay();
            rb2D = GetComponent<Rigidbody2D>(); // gets the ridig body of the player sets the rigid body 
            gameMan.GetComponent<gameManager>().set_player_to_true();
            anim = GetComponent<Animator>();

        
    }

    public void set_vel_0()
    {
        rb2D.velocity = new Vector2(0, 0);
    }

    public int orintation = 1; // right - 1 left - 0


	bool Apressed = false;
	bool Dpressed = false;

    void Update()      // making the player move. A goes left, D goes right 
    {


		if (Input.GetKeyDown (KeyCode.A) == true) {
			Apressed = true;
			GetComponent<SpriteRenderer>().flipX = true; 
		}

		if (Input.GetKeyUp (KeyCode.A) == true) {
			Apressed = false;
		}

		if (Input.GetKeyDown (KeyCode.D) == true) {
			Dpressed = true;
			GetComponent<SpriteRenderer> ().flipX = false;
		}

		if (Input.GetKeyUp (KeyCode.D) == true) {
			Dpressed = false;
		}
			

        if (walk == true)  // if the player is allowed to move 
        {

			if (Apressed == true)   // if the player presses a 
            {
                rb2D.velocity = new Vector2(-speed, 0);
				anim.SetInteger ("state", 1);

            }
			else { // when A is raised set velocity to 0 so he doesnt move

				if (Dpressed == true) {
					rb2D.velocity = new Vector2 (speed, 0);
					anim.SetInteger ("state", 1);
				} else {

					rb2D.velocity = new Vector2 (0, 0);

				}

            }
				
				
		}

		if ((Dpressed || Apressed) != true) {
			anim.SetInteger ("state", 0);
		}


			
	}
}