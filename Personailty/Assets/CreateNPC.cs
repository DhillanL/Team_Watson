using UnityEngine;
using System.Collections;

public class CreateNPC : MonoBehaviour {

    public gameManager Gameman;   //gamemanager

    public GameObject Tonald;
    public GameObject Bernard;
    public GameObject George;
    public GameObject Ethan;
    public GameObject Ryan;
    public GameObject Zoe;
    public GameObject Alice;
    public GameObject Sophie;
    public GameObject Stephen;
    public GameObject Robert;

    public NPC Tonald_Dump ;    //all test names for NPC
    public NPC Bernard_lowe ;
    public NPC George_allen;
    public NPC Ethan_hawk ;
	public NPC Ryan_Smith;
	public NPC Zoe_Williams;
	public NPC Alice_Davis;
	public NPC Sophie_Aaron;
	public NPC Stephen_Brown;
	public NPC Robert_Henry;


    public SpriteRenderer tonald_look;  // for the look of the NPC
    public SpriteRenderer bernard_look;
    public SpriteRenderer george_look;
    public SpriteRenderer ethan_look;
	public SpriteRenderer ryan_look;
	public SpriteRenderer zoe_look;
	public SpriteRenderer alice_look;
	public SpriteRenderer sophie_look;
	public SpriteRenderer stephen_look;
	public SpriteRenderer robert_look;

    public NPC[] npc_list_ = new NPC[10];        // lists for selecting a murder and a victim
    public NPC[] npc_list_vic_ = new NPC[9];


    public GameObject[] gameobjectlst_ = new GameObject[10];       // lists needed for creating the room allocation 
    public GameObject[] gameobjectlstshuffle_ = new GameObject[10];
   

    public void setNCPS()
    {
        Tonald_Dump = Tonald.GetComponent<NPC>();
        tonald_look = Tonald.GetComponent<SpriteRenderer>();    // to set the look 

        Bernard_lowe = Bernard.GetComponent<NPC>();
        bernard_look = Bernard.GetComponent<SpriteRenderer>();  // to set the look 

        George_allen = George.GetComponent<NPC>();
        george_look = George.GetComponent<SpriteRenderer>();

        Ethan_hawk = Ethan.GetComponent<NPC>();
        ethan_look = Ethan.GetComponent<SpriteRenderer>();

		Ryan_Smith = Ryan.GetComponent<NPC>();
        ryan_look = Ryan.GetComponent<SpriteRenderer>();

        Zoe_Williams = Zoe.GetComponent<NPC>();
        zoe_look = Zoe.GetComponent<SpriteRenderer>();

        Alice_Davis = Alice.GetComponent<NPC>();
        alice_look = Alice.GetComponent<SpriteRenderer>();

        Sophie_Aaron = Sophie.GetComponent<NPC>();
        sophie_look = Sophie.GetComponent<SpriteRenderer>();

        Stephen_Brown = Stephen.GetComponent<NPC>();
        stephen_look = Stephen.GetComponent<SpriteRenderer>();

        Robert_Henry = Robert.GetComponent<NPC>();
        robert_look = Robert.GetComponent<SpriteRenderer>();
    }

   
    public void make_tonald()   // set of tonalds attibutes to make his personailty
    {
        Tonald_Dump.Name = "Tonald";
        Tonald_Dump.intro = "I want to build a wall!";
        tonald_look.sprite = Tonald_Dump.look;                 //set look set from the sprite added to game object
         
        
    }

    public void make_bernard()   // set bernards 
    {
        Bernard_lowe.Name = "Bernard";
        Bernard_lowe.intro = "My name is bernard, I like lamps";
        bernard_look.sprite = Bernard_lowe.look;
    }



    public void make_George()
    {
        George_allen.Name = "George";
        george_look.sprite = George_allen.look;  
    }



    public void make_Ethan()
    {
        Ethan_hawk.Name = "Ethan";
        ethan_look.sprite = Ethan_hawk.look;
    }



    public void make_Ryan()
    {
		Ryan_Smith.Name = "Ryan";
		ryan_look.sprite = Ryan_Smith.look;
    }

    public void make_Zoe()
    {
        Zoe_Williams.Name = "Zoe";
		zoe_look.sprite = Zoe_Williams.look;
    }
    public void make_Alice()
    {
		Alice_Davis.Name = "Alice";
		alice_look.sprite = Alice_Davis.look;
    }

    public void make_Sophie()
    {
        Sophie_Aaron.Name = "Sophie";
		sophie_look.sprite = Sophie_Aaron.look;
    }

    public void make_Stephen()
    {
        Stephen_Brown.Name = "Stephen";
		stephen_look.sprite = Stephen_Brown.look;
    }

    public void make_Robert()
    {
		Robert_Henry.Name = "Robert";
		robert_look.sprite = Robert_Henry.look;
    }



    public void makelst()   //create a list of the npc's
    {
        npc_list_[0] = Tonald_Dump;
        npc_list_[1] = Bernard_lowe;
        npc_list_[2] = George_allen;
        npc_list_[3] = Ethan_hawk;
		npc_list_[4] = Ryan_Smith;
		npc_list_[5] = Zoe_Williams;
        npc_list_[6] = Alice_Davis;
		npc_list_[7] = Sophie_Aaron;
		npc_list_[8] = Stephen_Brown;
        npc_list_[9] = Robert_Henry;
    }


    public void makegameobjectlst()
    {
        gameobjectlst_[0] = Tonald;
        gameobjectlst_[1] = Bernard;
        gameobjectlst_[2] = George;
        gameobjectlst_[3] = Ethan;
        gameobjectlst_[4] = Ryan;
        gameobjectlst_[5] = Zoe;
        gameobjectlst_[6] = Alice;
        gameobjectlst_[7] = Sophie;
        gameobjectlst_[8] = Stephen;
        gameobjectlst_[9] = Robert;
    }






    public void set_murderer_and_victim()    //sets a NPC to be ther murder and a differnt npc to be the victim 
    {
        int x = Random.Range(0, 10);   // random number between 0 and 3
        npc_list_[x].isMurder();       // get npc at x in the array and set to muderer
        Gameman.GetComponent<gameManager>().set_murder(npc_list_[x]);    // store data in game manager 
        lst_no_murder();   // create list of all other npcs 
        int y = Random.Range(0, 9);   // pick number 
        npc_list_vic_[y].is_Victim();   // set as victim 
        Gameman.GetComponent<gameManager>().set_victim(npc_list_vic_[y]);  // store data 

    }

    public void lst_no_murder()   // creates a list of all other npcs who are not the murder. 
    {
        int y = 0;
        for (int x =0; x < npc_list_.Length; x++)
        {
            if (npc_list_[x].is_muderer == false)
            { 
                npc_list_vic_[y] = npc_list_[x];
                y++;
            } else
                ;
        }
    }




    public void shuffle_lst()    // prodcues a shuffled list of all the npcs; 
    {
        for(int x =0; x<gameobjectlst_.Length;x++)
        {
            int y = Random.Range(0, 10);
            while (gameobjectlstshuffle_[y] != null)
            {
                y = Random.Range(0, 10);
            }
            gameobjectlstshuffle_[y] = gameobjectlst_[x]; 
        }
    }



   

    public void setroom()
    {
        Gameman.GetComponent<gameManager>().setroom11(gameobjectlstshuffle_[0]);   //set the npc in room 1 pos 1 to shuffled index 0. 
        Gameman.GetComponent<gameManager>().setroom12(gameobjectlstshuffle_[1]);
        Gameman.GetComponent<gameManager>().setroom21(gameobjectlstshuffle_[2]);
        Gameman.GetComponent<gameManager>().setroom31(gameobjectlstshuffle_[3]);
        Gameman.GetComponent<gameManager>().setroom41(gameobjectlstshuffle_[4]);
        Gameman.GetComponent<gameManager>().setroom51(gameobjectlstshuffle_[5]);
        Gameman.GetComponent<gameManager>().setroom61(gameobjectlstshuffle_[6]);
        Gameman.GetComponent<gameManager>().setroom71(gameobjectlstshuffle_[7]);
        Gameman.GetComponent<gameManager>().setroom72(gameobjectlstshuffle_[8]);
        Gameman.GetComponent<gameManager>().setroom81(gameobjectlstshuffle_[9]);
    }








   


    public void Make_NPC() // called when initilased so to create all of the NPC's 
    {
        setNCPS();         // set the gaemobjects to the corect npc

        make_tonald();     // make all of the npcs adn sets them to the objects. 
        make_bernard();
        make_Ethan();
        make_George();
        make_Ryan();
        make_Zoe();
        make_Alice();
        make_Sophie();
        make_Stephen();
        make_Robert();

        makelst();
        makegameobjectlst();                   // make a list 

        shuffle_lst();                  //creates a shuffled list 

        setroom();                      // sets the npcs to a room

        set_murderer_and_victim();      // set a murdere and a victim

        //Gameman.GetComponent<gameManager>().populateroom1();   // populate room1.




    }






    // Use this for initialization
    void Start() {
        Make_NPC();
        Debug.Log("the murderer is: " + Gameman.GetComponent<gameManager>().get_murder());
        Debug.Log("the victim is: " + Gameman.GetComponent<gameManager>().get_victim());
        
    }


	
	// Update is called once per frame
	void Update () {
	
	}
}
