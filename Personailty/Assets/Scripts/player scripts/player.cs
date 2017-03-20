using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    // The player class 

    public bool playerno;  // public to select the player if its 1 or 2

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

    // new additions 

    public string PastScene = "Screen2";


    public void setPlay(bool player)    // sets the name personailty Aand the sprite for the player 
    {
        if (player == true)  // player1
        {
            data = gameMan.GetComponent<gameManager>();
            Name = data.getName();
            Personailty = data.getPersonality();
            personint = data.getpersonint();
        } else
        {
            data = gameMan.GetComponent<gameManager>();
            Name = data.getnameplayer2();
            Personailty = data.getplayer2person();
            personint = data.getperson2();
        }
        
      
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
        setPlay(playerno);
        rb2D = GetComponent<Rigidbody2D>(); // gets the ridig body of the player sets the rigid body 
        gameMan.GetComponent<gameManager>().set_player_to_true();
        anim = GetComponent<Animator>();
    }

    public void set_vel_0()
    {
        rb2D.velocity = new Vector2(0, 0);
    }

    public int orintation = 1; // right - 1 left - 0

	public bool Apressed = false;
	public bool Dpressed = false;
	public string lastScene = "";

    void Update()      // making the player move. A goes left, D goes right 
    {

        

        if (lastScene != SceneManager.GetActiveScene().name) {
			Apressed = false;
			Dpressed = false;
		}
		lastScene = SceneManager.GetActiveScene().name;

		if (Input.GetKeyDown (KeyCode.A) == true) {
			Apressed = true;
		}

		if (Input.GetKeyUp (KeyCode.A) == true) {
			Apressed = false;
		}

		if (Input.GetKeyDown (KeyCode.D) == true) {
			Dpressed = true;
		}

		if (Input.GetKeyUp (KeyCode.D) == true) {
			Dpressed = false;
		}
			

        if (walk == true)  // if the player is allowed to move 
        {

			if (Apressed == true) {
				rb2D.velocity = new Vector2 (-speed, 0);
				GetComponent<SpriteRenderer> ().flipX = true; 
				anim.SetInteger ("state", 1);

			} else if (Dpressed == true) {
				rb2D.velocity = new Vector2 (speed, 0);
				GetComponent<SpriteRenderer> ().flipX = false;
				anim.SetInteger ("state", 1);
			} else {
					rb2D.velocity = new Vector2 (0, 0);
					anim.SetInteger ("state", 0);
				}

            }
				
				
		}
}