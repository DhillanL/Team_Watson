using UnityEngine;
using System.Collections;
using System.Linq;  // to be able to use contains in array checking 

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


    // list to make accessing the clue easier 
    public GameObject[] gameobjectlst_ = new GameObject[8];  // list of all of the gamobject -- the clues 
    public GameObject[] gameobjectlstverbal_ = new GameObject[2];




    // initlaise all of the game objects to have clue attributes 
	public void setClues()
    {
        // get the components for each of the clues 
		clue_1 = clue1.GetComponent<clue>();
        clue_1.cluename = "Clue1";
        clue1.GetComponent<SpriteRenderer>().sprite = clue_1.look ;

		clue_2 = clue2.GetComponent<clue>();
        clue_2.cluename = "Clue2";
        clue2.GetComponent<SpriteRenderer>().sprite = clue_2.look;

        clue_3 = clue3.GetComponent<clue>();
        clue_3.cluename = "Clue3";
        clue3.GetComponent<SpriteRenderer>().sprite = clue_3.look ;

        clue_4 = clue4.GetComponent<clue>();
        clue_4.cluename = "Clue4";
        clue4.GetComponent<SpriteRenderer>().sprite = clue_4.look ;

        clue_5 = clue5.GetComponent<clue>();
        clue_5.cluename = "Clue5";
        clue5.GetComponent<SpriteRenderer>().sprite = clue_5.look ;

        clue_6 = clue6.GetComponent<clue>();
        clue_6.cluename = "Clue6";
        clue6.GetComponent<SpriteRenderer>().sprite = clue_6.look  ;

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
        clue_5.info = "Hat has two sets of initials in it, "+ game_manager.GetComponent<gameManager>().get_whole_murderer().initial + " and " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].initial ;

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

    

	

	public void make_game_object_lst(){
		gameobjectlst_ [0] = clue1;
		gameobjectlst_ [1] = clue2;
		gameobjectlst_ [2] = clue3;
		gameobjectlst_ [3] = clue4;
		gameobjectlst_ [4] = clue5;
		gameobjectlst_ [5] = clue6;
		
	}

    public void make_gameobj_lst_verbal()
    {
        gameobjectlstverbal_[0] = clue7_verbal;
        gameobjectlstverbal_[1] = clue8_verbal;

    }

    public NPC getNPC(int x)
    {
        return createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[x];
        
    }



	public void setCluesInGameman(){

        int[] clue_room_pos_ = new int[8] {0,1,2,3,4,5,6,7};
        int[] random_room_pos = new int[6];


        for ( int a = 0; a<6; a++ )  // produces a random list of 6 differnt ints from 0 to 7 
        {
            int b = Random.Range(0, clue_room_pos_.Length);
            int c = clue_room_pos_[b];

            while (c == 10)    // just using a radnom number to fill in he space with once its been read so it wont be selected again 
            {
                b = Random.Range(0, clue_room_pos_.Length);
                c = clue_room_pos_[b];
            }
            random_room_pos[a] = clue_room_pos_[b];
            clue_room_pos_[b] = 10;

        }

        for (int c = 0; c < 6; c++)
        {
            int d = random_room_pos[c];
            
            if (d == 0)
            {
                game_manager.GetComponent<gameManager>().setClue1(gameobjectlst_[c]);
            }
            else if (d == 1)
            {
                game_manager.GetComponent<gameManager>().setClue2(gameobjectlst_[c]);
            }
            else if (d == 2)
            {
                game_manager.GetComponent<gameManager>().setClue3(gameobjectlst_[c]);
            }
            else if (d == 3)
            {
                game_manager.GetComponent<gameManager>().setClue4(gameobjectlst_[c]);
            }
            else if (d == 4)
            {
                game_manager.GetComponent<gameManager>().setClue5(gameobjectlst_[c]);
            }
            else if (d == 5)
            {
                game_manager.GetComponent<gameManager>().setClue6(gameobjectlst_[c]);
            }
            else if (d == 6)
            {
                game_manager.GetComponent<gameManager>().setClue7(gameobjectlst_[c]);
            }
            else
            {
                game_manager.GetComponent<gameManager>().setClue8(gameobjectlst_[c]);
            }
        }
             




        // rnadomly assign NPC's the verbal clues 
        int x = Random.Range(0, 8);
        int y = x;
        while (y == x)
        {
            y = Random.Range(0, 8);  // ensures two different NPC's
        }
        game_manager.GetComponent<gameManager>().setNPCclue(getNPC(x),gameobjectlstverbal_[0]);  // sets the verbal clues of two random npcs 
        game_manager.GetComponent<gameManager>().setNPCclue(getNPC(y), gameobjectlstverbal_[1]);
    }




    // called to create all of the clues 
	public void makeClues(){

        setClues();   // intialise 

		make_game_object_lst();   // make lists 
        make_gameobj_lst_verbal();
		

        set_clues_crime();    // depending on crime choosen at random make approiate clues 

		setCluesInGameman();
	}

	void awake() { 
		Debug.Log("clues made");

	}

	void Update () {

	}
}