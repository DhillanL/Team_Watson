using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public Sprite look;    //sprite used for picture

    public string Name;
   
    public bool is_muderer = false;
    public bool is_accused = false;
    public bool is_victim = false;

    public bool first_interaction = true;

    public string clue;

    public string intro;

    public GameObject interaction;

    //BadCop
    string arrgesive_reposne;
    string violent_reponse;
    string threaten_response;

    //GoodCop
    public string kind_response;
    public string symethic_respose;
    public string friendly_reponse;


    Vector3 newPos = new Vector3(-300,-12,0);   // starting pos for all of the NPCS

    public GameObject Interaction;
    public GameObject me;

    public void reponse()
    {
        




    } 

    

   

    public void isMurder()
    {
        is_muderer = true;
    }


    public void is_Victim()
    {
        is_victim = true;
    }


    public void reset_pos()
    {
        transform.position = newPos;
    }


    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    void OnMouseDown()
    {
        Interaction.GetComponent<Interaction>().setNPC(me.GetComponent<NPC>());
        Debug.Log("test");
        Interaction.GetComponent<Interaction>().pick_interaction();
    }









    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
