using UnityEngine;           // modules used in the script 
using System.Collections;
using UnityEngine.UI;


public class clue: MonoBehaviour{

    /* clue is the class from which all of the clue objects will be build from. It contains all of the attribtes that will be needed to create a clue for the game 
     * */
    
   // attributes for the clues 
    public string cluename;
	public string name;
    public string info;
 
    public bool is_found = false;
    public bool is_verbal = false;

    public NPC npc_verbal;
	public Sprite look;
	public GameObject Interaction;
	public GameObject me;  // reference the game object that the clue is 
    public GameObject GameManger;

    Vector3 newPos = new Vector3(-240, -10, 0); // starting pos for all clues

    public void reset_pos()  // make clues go back to off screen when they arent being shown 
    {
        transform.position = newPos;
    }


	public string getName()  // accessor to get the name of a clue 
    {
		return name;
	}

	public string getInfo()  // accesssor to get the info for the clue
    {
        return info;  
	}



    void OnMouseDown() // When the clue is clicked on it is removed and added to the logbook
    {
        GameManger = GameObject.FindWithTag("gamemanager");
        is_found = true;
        GameManger.GetComponent<gameManager>().increase_clue_count();
        reset_pos(); 
        GameObject.FindWithTag("logbookparts").GetComponent<logbookparts>().add_clue(this);  // add the clue and its info to the logbook 
    }


	void Awake()  // when the clue is first created set it so it doesnt get detroyed when you load a new scene
    {
		DontDestroyOnLoad(transform.gameObject);
	}
	
}


