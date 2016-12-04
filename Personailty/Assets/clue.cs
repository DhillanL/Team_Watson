using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class clue: MonoBehaviour{

    public string cluename;

	public string name;
	//public string NPC = null;
    public string info;
   // public string Room_found; 


    public bool is_found = false;
    //public bool is_bloody = false;
    // public string NPC_text = null;

    public bool in_log = false;



	public Sprite look;

	public GameObject Interaction;
	public GameObject me;

    public GameObject GameManger;


    Vector3 newPos = new Vector3(-240, -10, 0); // starting pos for all clues

    public void reset_pos()
    {
        transform.position = newPos;
    }


	public string getName(){
		return name;
	}

	public void getInfo(){  
	}



    void OnMouseDown()
    {

        GameManger = GameObject.FindWithTag("gamemanager");

        is_found = true;
        GameManger.GetComponent<gameManager>().increase_clue_count();
        Debug.Log(GameManger.GetComponent<gameManager>().get_clue_count());  // debuging 
        Debug.Log("click");   // debugging 
       // reset_pos(); // will be used to make it go away once it has been clicked on the screen 
       // NEED TO ADD THE FUNCTIONS TO ADD INFORAMTION INTO THE LOG BOOK  -- call from the logbook class 



    }

	


	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	void Update () {

	}
}


