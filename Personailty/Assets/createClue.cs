using UnityEngine;
using System.Collections;


public class createClue: MonoBehaviour{

	public GameObject game_manager;
    public GameObject crime;
    public GameObject createnpc;


    // the game objects which hold the clues 
	public GameObject clue1;
	public GameObject clue2;
	public GameObject clue3;
	public GameObject clue4;
	public GameObject clue5;
	public GameObject clue6;
	public GameObject clue7_verbal;
	public GameObject clue8_verbal;

    // the attributes for the clue which are attached to the game objects 
	public clue clue_1;
	public clue clue_2;
	public clue clue_3;
	public clue clue_4;
	public clue clue_5;
	public clue clue_6;
	public clue verbal_clue_7;
	public clue verbal_clue_8;

    // the looks of the clues 
	public SpriteRenderer clue1_look;
	public SpriteRenderer clue2_look;
    public SpriteRenderer clue3_look;
    public SpriteRenderer clue4_look;
    public SpriteRenderer clue5_look;
    public SpriteRenderer clue6_look;


    // list to make accessing the clue easier 
    public GameObject[] gameobjectlst_ = new GameObject[8];  // list of all of the gamobject -- the clues 

	public clue[] physical_clue_list = new clue[6];  // hold ths clue elememtns of all the clues 
	public clue[] verbal_clue_list = new clue[2];


    // initlaise all of the game objects to have clue attributes 
	public void setClues()
    {
        // get the components for each of the clues 
		clue_1 = clue1.GetComponent<clue>();
		clue1_look = clue1.GetComponent<SpriteRenderer>();

		clue_2 = clue2.GetComponent<clue>();
		clue2_look = clue2.GetComponent<SpriteRenderer>();

        clue_3 = clue3.GetComponent<clue>();
        clue3_look = clue3.GetComponent<SpriteRenderer>();

        clue_4 = clue4.GetComponent<clue>();
        clue4_look = clue4.GetComponent<SpriteRenderer>();

        clue_5 = clue5.GetComponent<clue>();
        clue5_look = clue5.GetComponent<SpriteRenderer>();

        clue_6 = clue6.GetComponent<clue>();
        clue6_look = clue6.GetComponent<SpriteRenderer>();

        verbal_clue_7 = clue7_verbal.GetComponent<clue>();
        
        verbal_clue_8 = clue8_verbal.GetComponent<clue>();
    }


    // make all of the clues if the murder if STAB IN BACK CRIME 
    public void make_clues_crime_1()
    {
        string[] weapons = new string[3]{ "Flick Knife", "Meat Clever", "Rather sharp pencil" };
        int x = Random.Range(0, 3);   // pick a random murder weapon
        clue_1.name = weapons[x];
        clue_1.info = "the blade looks smudged, maybe something was wiped off?";
        // clue_1.look = clue1_look; need to fix look  

        string[] throw_off_weapon = new string[3] { "swiss army knife", "dagger", "sword" };
        int y = Random.Range(0, 3);
        clue_2.name = throw_off_weapon[y];
        clue_2.info = "the blade looks clean....maybe too clean?";

        clue_3.name = "Hand written not to Victim";
        clue_3.info = ("A note addressed to " + game_manager.GetComponent<gameManager>().get_victim() + ". Saying 'Meet in " +
            game_manager.GetComponent<gameManager>().get_whole_victim().room + "with £5000 or else' \n It is written in black handwriting");

        clue_4.name = "cloth with blood on";
        clue_4.info = "Must have been used to wipe the murder weapon";

        string[] hat = new string[3] { "Black top hat", "flat cap", "beanie" };
        int z = Random.Range(0, 3);
        clue_5.name = hat[z];
        clue_2.info = "Hat has two sets of initials in it, "+ game_manager.GetComponent<gameManager>().get_whole_victim().initial + " and " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].initial ;

        clue_6.name = "Black foutain pen";
        clue_6.info = "A black fountain pen, looks expensive";

        verbal_clue_7.name = ("saw someone hanging around " + game_manager.GetComponent<gameManager>().get_whole_victim().room + " wearing a " + hat[z]
            + ". " + game_manager.GetComponent<gameManager>().get_whole_murderer().he_she +  " looked a bit shifty.");

        verbal_clue_8.name = "I saw " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].Name + " playing with a " + throw_off_weapon[y] + " ealier";

    }

    // make all clues if the crime is // DROWNING 
    public void make_clues_crime_2()   // testing debuggin procedure 
    {
        string[] weapons = new string[3] { "club", "bat", "wood" };
        int x = Random.Range(0, 3);   // pick a random murder weapon
        clue_1.name = weapons[x];
        clue_1.info = "the blade looks smudged, maybe something was wiped off?";
        // clue_1.look = clue1_look; need to fix look  

        string[] throw_off_weapon = new string[3] { "ball", "racket", "plank" };
        int y = Random.Range(0, 3);
        clue_2.name = throw_off_weapon[y];
        clue_2.info = "the blade looks clean....maybe too clean?";


    }

    // depending on the murder selcted in the create crime scirpt the approiate clue will be selected. 
    public void set_clues_crime()
    {
        if (crime.GetComponent<CreateCrime>().murder_int == 0)   // clues only set for if the murder is the STABBED IN THE BACK  rest need to be done still 
        {
            make_clues_crime_1();
        }
        else
        {
            make_clues_crime_2();
        }

    }



	public void make_physical_clue_list(){ //make list of physical clues
		physical_clue_list [0] = clue_1;
		physical_clue_list [1] = clue_2;
		physical_clue_list [2] = clue_3;
		physical_clue_list [3] = clue_4;
		physical_clue_list [4] = clue_5;
		physical_clue_list [5] = clue_6;
	}

	public void make_verbal_clue_list(){ //make list of physical clues
		verbal_clue_list [0] = verbal_clue_7;
		verbal_clue_list [1] = verbal_clue_8;
	}

	public void make_game_object_lst(){
		gameobjectlst_ [0] = clue1;
		gameobjectlst_ [1] = clue2;
		gameobjectlst_ [2] = clue3;
		gameobjectlst_ [3] = clue4;
		gameobjectlst_ [4] = clue5;
		gameobjectlst_ [5] = clue6;
		gameobjectlst_ [6] = clue7_verbal;
		gameobjectlst_ [7] = clue8_verbal;
	}

    public NPC getNPC(int x)
    {
        return createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[x];
        
    }

	public void setCluesInGameman(){
		game_manager.GetComponent<gameManager>().setClue1(gameobjectlst_[0]);
		game_manager.GetComponent<gameManager>().setClue2(gameobjectlst_[1]);
		game_manager.GetComponent<gameManager>().setClue3(gameobjectlst_[2]);
		game_manager.GetComponent<gameManager>().setClue4(gameobjectlst_[3]);
		game_manager.GetComponent<gameManager>().setClue5(gameobjectlst_[4]);
		game_manager.GetComponent<gameManager>().setClue6(gameobjectlst_[5]);
        int x = Random.Range(0, 8);
        int y = x;
        while (y == x)
        {
            y = Random.Range(0, 8);  // ensures two different NPC's
        }
        game_manager.GetComponent<gameManager>().setNPCclue(getNPC(x),gameobjectlst_[6]);  // sets the verbal clues of two random npcs 
        game_manager.GetComponent<gameManager>().setNPCclue(getNPC(y), gameobjectlst_[7]);
    }




    // called to create all of the clues 
	public void makeClues(){

        setClues();   // intialise 

		make_game_object_lst();   // make lists 
		make_physical_clue_list();
		make_verbal_clue_list();

        set_clues_crime();    // depending on crime choosen at random make approiate clues 

		setCluesInGameman();
	}

	void awake() { 
		Debug.Log("clues made");

	}

	void Update () {

	}
}