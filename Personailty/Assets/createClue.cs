using UnityEngine;
using System.Collections;


public class createClue: MonoBehaviour{

	public gameManager game_manager;

	public GameObject rope;
	public GameObject stick;
	public GameObject clue3;
	public GameObject clue4;
	public GameObject clue5;
	public GameObject clue6;
	public GameObject clue7;
	public GameObject clue8;
	public GameObject clue9;

	public clue clue_rope;
	public clue clue_stick;
	public clue clue_3;
	public clue clue_4;
	public clue clue_5;
	public clue clue_6;
	public clue verbal_clue_1;
	public clue verbal_clue_2;

	public SpriteRenderer rope_look;
	public SpriteRenderer stick_look;

	public GameObject[] gameobjectlst = new GameObject[6];

	public clue[] physical_clue_list = new clue[6];
	public clue[] verbal_clue_list = new clue[2];

	public void setClues(){
		clue_rope = rope.GetComponent<clue>();
		rope_look = rope.GetComponent<SpriteRenderer>();

		clue_stick = stick.GetComponent<clue>();
		stick_look = stick.GetComponent<SpriteRenderer>();
	}

	public void make_rope() {
		clue_rope.name = "Rope";
		clue_rope.is_visiable = true;
		clue_rope.is_bloody = true;
		rope_look.sprite = clue_rope.look;
	}

	public void make_stick() {
		clue_rope.name = "Stick";
		clue_rope.is_visiable = true;
		clue_rope.is_bloody = true;
		stick_look.sprite = clue_stick.look;
	}

	public void make_physical_clue_list(){ //make list of physical clues
		physical_clue_list [1] = clue_rope;
		physical_clue_list [2] = clue_stick;
		physical_clue_list [3] = clue_3;
		physical_clue_list [4] = clue_4;
		physical_clue_list [3] = clue_5;
		physical_clue_list [4] = clue_6;
	}

	public void make_verbal_clue_list(){ //make list of physical clues
		verbal_clue_list [1] = verbal_clue_1;
		verbal_clue_list [2] = verbal_clue_2;
	}

	public void make_game_object_lst(){
		gameobjectlst [1] = rope;
		gameobjectlst [2] = stick;
		gameobjectlst [3] = clue3;
		gameobjectlst [4] = clue4;
		gameobjectlst [5] = clue5;
		gameobjectlst [6] = clue6;
		gameobjectlst [7] = clue7;
		gameobjectlst [8] = clue8;
	}

	public void setCluesInGameman(){
		game_manager.GetComponent<gameManager>().setClue1(gameobjectlst[1]);
		game_manager.GetComponent<gameManager>().setClue2(gameobjectlst[2]);
		game_manager.GetComponent<gameManager>().setClue3(gameobjectlst[3]);
		game_manager.GetComponent<gameManager>().setClue4(gameobjectlst[4]);
		game_manager.GetComponent<gameManager>().setClue5(gameobjectlst[5]);
		game_manager.GetComponent<gameManager>().setClue6(gameobjectlst[6]);
		game_manager.GetComponent<gameManager>().setClue7(gameobjectlst[7]);
		game_manager.GetComponent<gameManager>().setClue8(gameobjectlst[8]);
	}
	public void makeClues(){
		setClues();

		make_rope();
		make_stick();

		make_game_object_lst();
		make_physical_clue_list();
		make_verbal_clue_list();
		setCluesInGameman();
	}

	void awake(){
		makeClues ();
		Debug.Log("clues made");

	}

	void Update () {

	}
}