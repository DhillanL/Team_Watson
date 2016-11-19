using UnityEngine;
using System.Collections;

public class CreateNPC : MonoBehaviour {

    public gameManager Gameman;   //gamemanager

    public GameObject Tonald;
    public GameObject Bernard;
    public GameObject George;
    public GameObject Ethan;

    public NPC Tonald_Dump ;    //all test names for NPC
    public NPC Bernard_lowe ;
    public NPC George_allen;
    public NPC Ethan_hawk ;

    public SpriteRenderer tonald_look;  // for the look of the NPC
    public SpriteRenderer bernard_look;
    public SpriteRenderer george_look;
    public SpriteRenderer ethan_look;

    public NPC[] npc_list = new NPC[4];        // lists for selecting a murder and a victim ... will need to make correct size when all NPC's are in the game 
    public NPC[] npc_list_vic = new NPC[3];


    public GameObject[] gameobjectlst = new GameObject[4];
    public GameObject[] gameobjectlstshuffle = new GameObject[4];
   

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
    }

   
    public void make_tonald()   // set of tonalds attrutes 
    {
        Tonald_Dump.Name = "Tonald";
        Tonald_Dump.intro = "I want to build a wall!";
        tonald_look.sprite = Tonald_Dump.look;                 //set look set from the sprite added to gaem object 
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






    public void makelst()   //create a list of the npc's
    {
        npc_list[0] = Tonald_Dump;
        npc_list[1] = Bernard_lowe;
        npc_list[2] = George_allen;
        npc_list[3] = Ethan_hawk;       
    }

    public void makegameobjectlst()
    {
        gameobjectlst[0] = Tonald;
        gameobjectlst[1] = Bernard;
        gameobjectlst[2] = George;
        gameobjectlst[3] = Ethan;
    }






    public void set_murderer_and_victim()    //sets a NPC to be ther murder and a differnt npc to be the victim 
    {
        int x = Random.Range(0, 4);   // random number between 0 and 3
        npc_list[x].isMurder();       // get npc at x in the array and set to muderer
        Gameman.GetComponent<gameManager>().set_murder(npc_list[x]);    // store data in game manager 
        lst_no_murder();   // create list of all other npcs 
        int y = Random.Range(0, 3);   // pick number 
        npc_list_vic[y].is_Victim();   // set as victim 
        Gameman.GetComponent<gameManager>().set_victim(npc_list_vic[y]);  // store data 

    }

    public void lst_no_murder()   // creates a list of all other npcs who are not the murder. 
    {
        int y = 0;
        for (int x =0; x < npc_list.Length; x++)
        {
            if (npc_list[x].is_muderer == false)
            { 
                npc_list_vic[y] = npc_list[x];
                y++;
            } else
                ;
        }
    }




    public void shuffle_lst()    // prodcues a shuffled list of all the npcs; 
    {
        for(int x =0; x<gameobjectlst.Length;x++)
        {
            int y = Random.Range(0, 4);
            while (gameobjectlstshuffle[y] != null)
            {
                y = Random.Range(0, 4);
            }
            gameobjectlstshuffle[y] = gameobjectlst[x]; 
        }
    }



   

    public void setroom()
    {
        Gameman.GetComponent<gameManager>().setroom11(gameobjectlstshuffle[0]);   //set the npc in room 1 pos 1 to shuffled index 0. 
        Gameman.GetComponent<gameManager>().setroom12(gameobjectlstshuffle[1]);
        Gameman.GetComponent<gameManager>().setroom21(gameobjectlstshuffle[2]);
    }




   


    public void Make_NPC() // called when initilased so to create all of the NPC's 
    {
        setNCPS();         // set the gaemobjects to the corect npc

        make_tonald();     // make all of the npcs adn sets them to the objects. 
        make_bernard();
        make_Ethan();
        make_George();

        makelst();
        makegameobjectlst();                   // make a list 

        shuffle_lst();                  //creates a shuffled list 

        setroom();                      // sets the npcs to a room

        set_murderer_and_victim();      // set a murdere and a victim

        Gameman.GetComponent<gameManager>().populateroom1();   // populate room1.




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
