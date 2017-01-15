using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    static public bool spwaned = false;

    public Text speach_box;

    public string Name;                       // name of the player 
    public Personality_player Personailty ;   //personailty of the player 
    public Sprite Sprite;                     //look of the player
    public int personint;
    Animator anim;


    public GameObject gameMan;
    private gameManager data;  //data from the gamemanager script 

    public GameObject Player;    //reference the player so we can change the look 
    

    public int interactions;

    public bool clear_interact = false;

    public float speed = 70f;
    private Rigidbody2D rb2D;

    public AudioClip walking;

    private bool test = true;


    public void setPlay()    // sets the name personailty Aand the sprite for the player 
    {
        data = gameMan.GetComponent<gameManager>();
        Name = data.getName();
        Personailty = data.getPersonality();
        personint = data.getpersonint();
        //Sprite = data.getSprite();
        //Player.GetComponent<SpriteRenderer>().sprite = Sprite;
    }

    public void testT()
    {
        test = true;
    }

    public void testF()
    {
        test = false ;
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

    public int orintation = 1; // right - 1 left - 0

    void Update()      // making the player move. A goes left, D goes right 
    {

        if (test)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb2D.velocity = new Vector2(-speed, 0);

                if (orintation == 1)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                }

                anim.SetInteger("state", 1);
                orintation = 0;

            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                rb2D.velocity = new Vector2(0, 0);
                anim.SetInteger("state", 0);

            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                rb2D.velocity = new Vector2(speed, 0);



                if (orintation == 0)
                {
                    GetComponent<SpriteRenderer>().flipX = false;
                }
                anim.SetInteger("state", 1);
                orintation = 1;


            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                rb2D.velocity = new Vector2(0, 0);
                anim.SetInteger("state", 0);
            }


        }
    }



}
