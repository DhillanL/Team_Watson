using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public GameObject Player;
    public player player;
    public NPC npc;

    public Text speachbox ;                // The speach box 

    public InputField player_input;        // Where the player can input their choices
    public Button pick_interaction_type;   // Clicked when picked wether to Question or accuse
    public Button pick_questioning_style;  // clicked when selecting the question they want to ask

  
    public string question_style_text;



    public void setNPC(NPC npcin)
    {
        npc = npcin;
    }

	public string npc_response()
	{
		switch(question_style_text)
		{
		case "Aggressive":
			return (npc.aggressive_response);
			break;
		case "Violent":
			return (npc.violent_response);
			break;
		case "Threaten":
			return (npc.threaten_response);
			break;
		case "Arrogant":
			return (npc.arrogant_response);
			break;
		case "Indifferent":
			return (npc.indifferent_response);
			break;
		case "Kind":
			return (npc.kind_response);
			break;
		case "Friendly":
			return (npc.friendly_response);
			break;
		case "Humorous":
			return (npc.humorous_response);
			break;
		case "Enthusiastic":
			return (npc.enthusiastic_response);
			break;
		default:
			return (npc.symethic_response);
			break;
		}
	}





    public void pick_interaction()
    {
        if (npc.okay_to_interact == true)
        {
            if (npc.first_interaction == true)
            {
                speachbox.text = "detective " + player.Name + " :  " + player.Personailty.intro;

                speachbox.text = speachbox.text + "\n\n" + npc.Name + ": " + npc.intro;

                npc.first_interaction = false;

                npc = null;
            }
            else
            {
                speachbox.text = "how would you like to interact: \n1. Question \n2. Accuse";
                player_input.transform.Translate(250, 0, 0);                                // bring in the input and cnfirm boxes
                pick_interaction_type.transform.Translate(250, 0, 0);
            }

        }
        else
        {
            speachbox.text = npc.name + ": " + npc.dont_interact_response;
            npc = null;
        }
        
    }






    public void pick_question() // pick the question sytle -- called after selected interaction type
    {
        if(player_input.text.Equals("1"))
        {
            speachbox.text = "select questioing method:\n1. " + player.Personailty.type1() + "\n2. " + player.Personailty.type2() + "\n3. " + player.Personailty.type3();
            player_input.text = "";                                // make input box empty
            pick_interaction_type.transform.Translate(-250, 0, 0);
            pick_questioning_style.transform.Translate(250,0,0); // button comes in to call questioning style
        } else if(player_input.text.Equals("2"))
        {
            speachbox.text = "accuse";
        } else
        {
            speachbox.text = "please enter in correct format and interact again";
        }
    }





    public void questioing_style()  //-- called after the question has been selected need to finish all of the interaction still. 
    {
        if (player_input.text.Equals("1"))   // if the player chooses to perform question option 1 
        {
            question_style_text = player.Personailty.questiontype1;
            speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question1();
            speachbox.text += "\n\n" + npc.Name + ": " +npc_response();
            check_okay_to_interact();
            pick_questioning_style.transform.Translate(-250, 0, 0);
            player_input.transform.Translate(-250, 0, 0);
            npc = null;



        } else if (player_input.text.Equals("2"))
        {
            question_style_text = player.Personailty.questiontype2;
            speachbox.text = player.Personailty.Question2();
            speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
            check_okay_to_interact();
            pick_questioning_style.transform.Translate(-250, 0, 0);
            player_input.transform.Translate(-250, 0, 0);
            npc = null;

        } else if (player_input.text.Equals("3"))
        {
            question_style_text = player.Personailty.questiontype3;
            speachbox.text = player.Personailty.Question3();
            speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
            check_okay_to_interact();
            pick_questioning_style.transform.Translate(-250, 0, 0);
            player_input.transform.Translate(-250, 0, 0);
            npc = null;


        } else
        {
            ;
        }

        
    }

    

    public void check_okay_to_interact()
    {
        if (npc_response().Equals(npc.dont_interact_if1) || npc_response().Equals(npc.dont_interact_if2) || npc_response().Equals(npc.dont_interact_if3))
        {
            npc.okay_to_interact = false;
        }
        else
        {
            npc.okay_to_interact = true;
        }
    }
             

    public void accuse()
    {

    }


    // Use this for initialization
    void Start () {
        Player = GameObject.FindWithTag("Player");
        player = Player.GetComponent<player>();
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
