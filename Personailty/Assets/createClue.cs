using UnityEngine;
using System.Collections;


public class createClue: MonoBehaviour{

	public GameObject game_manager;
    public GameObject crime;


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
	public clue verbal_clue_1;
	public clue verbal_clue_2;

    // the looks of the clues 
	public SpriteRenderer clue1_look;
	public SpriteRenderer clue2_look;


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
		clue2_look = clue1.GetComponent<SpriteRenderer>();
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
        if (crime.GetComponent<CreateCrime>().murder_int == 0)
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
		verbal_clue_list [0] = verbal_clue_1;
		verbal_clue_list [1] = verbal_clue_2;
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

	public void setCluesInGameman(){
		game_manager.GetComponent<gameManager>().setClue1(gameobjectlst_[0]);
		game_manager.GetComponent<gameManager>().setClue2(gameobjectlst_[1]);
		game_manager.GetComponent<gameManager>().setClue3(gameobjectlst_[2]);
		game_manager.GetComponent<gameManager>().setClue4(gameobjectlst_[3]);
		game_manager.GetComponent<gameManager>().setClue5(gameobjectlst_[4]);
		game_manager.GetComponent<gameManager>().setClue6(gameobjectlst_[5]);
		game_manager.GetComponent<gameManager>().setClue7(gameobjectlst_[6]);
		game_manager.GetComponent<gameManager>().setClue8(gameobjectlst_[7]);
	}




    // called to create all of the clues 
	public void makeClues(){

        setClues();   // intialise 

		make_game_object_lst();   // make lists 
		make_physical_clue_list();
		make_verbal_clue_list();

        set_clues_crime();    // depending on crime choosen at random make approiate clues 


        Debug.Log(clue_1.name);  // debugging work 
        Debug.Log(clue_1.info);
		//setCluesInGameman();
	}

	void awake() { 
		Debug.Log("clues made");

	}

	void Update () {

	}
}