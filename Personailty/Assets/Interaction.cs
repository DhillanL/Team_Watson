using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public GameObject Player;
    public player player;
    public NPC npc;

    public Text speachbox ;    // the speach box 

    public InputField player_input;     //wher the player can input their choices
    public Button pick_interaction_type;  // clicked when picked wether to Question or accuse
    public Button pick_questioning_style;

    public string question_style_text;

    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void setNPC(NPC npcin)
    {
        npc = npcin;
    }

    public void pick_interaction()
    {
        if (npc.first_interaction == true)
        {
            speachbox.text  = player.Personailty.intro;
            
            speachbox.text = speachbox.text + "\n" + npc.intro;

            npc.first_interaction = false;
        } else
        {
            speachbox.text = "how would you like to interact: \n1. Question \n2. Accuse";
            player_input.transform.Translate(220,0,0);
            pick_interaction_type.transform.Translate(220, 0, 0);
        }
    }

    public void pick_question() // pick the question sytle -- called after selected interaction type
    {
        if(player_input.text.Equals("1"))
        {
            speachbox.text = "select questioing method:\n1. " + player.Personailty.type1() + "\n2. " + player.Personailty.type2() + "\n3. " + player.Personailty.type3();
            player_input.text = "";                                // make input box empty
            pick_questioning_style.transform.Translate(220,0,0); // button comes in to call questioning style
        } else if(player_input.text.Equals("2"))
        {
            speachbox.text = "accuse";
        } else
        {
            speachbox.text = "please enter in correct format and interact again";
        }
    }


    public void questioing_style()  //-- called after the question has been selected need to finish all of the nteraction still. 
    {
        if (player_input.text.Equals("1"))
        {
            question_style_text = player.Personailty.questiontype1;
            speachbox.text = player.Personailty.Question1();

        } else if (player_input.text.Equals("2"))
        {
            question_style_text = player.Personailty.questiontype2;
            speachbox.text = player.Personailty.Question2();

        } else if (player_input.text.Equals("3"))
        {
            question_style_text = player.Personailty.questiontype3;
            speachbox.text = player.Personailty.Question3();

        } else
        {
            ;
        }

        
    }

                

    public void accuse()
    {

    }


    // Use this for initialization
    void Start () {
        player = Player.GetComponent<player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
