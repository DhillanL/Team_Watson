using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class clue: MonoBehaviour{

    // Defining values to each clue, name, info, is found and is a verbal clue

    public string cluename;

	public string name;
	
    public string info;
 

    public bool is_found = false;
    public bool is_verbal = false;

    public NPC npc_verbal;

	public Sprite look;

	public GameObject Interaction;
	public GameObject me;

    // Initialises the clue object in the game manager

    public GameObject GameManger;




    Vector3 newPos = new Vector3(-240, -10, 0); // starting pos for all clues

    public void reset_pos()
    {
        transform.position = newPos;
    }


	public string getName(){
		return name;
	}

	public string getInfo()
    {
        return info;  
	}



    void OnMouseDown() // When the clue is clicked on it is removed and added to the logbook
    {
        GameManger = GameObject.FindWithTag("gamemanager");
        is_found = true;
        GameManger.GetComponent<gameManager>().increase_clue_count();
        Debug.Log("click");   
        reset_pos(); 
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().add_clue(this);

    }

	


	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	void Update () {

	}
}


