using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public GameObject Player;
    public player player;
    public NPC npc;

    public Text speachbox ;                // The speach box 

    public Button question;        // Where the player can input their choices
    public Button accusebutt;
    public Button questioingtype1;
    public Button questioingtype2;
    public Button questioingtype3;

  
    public string question_style_text;



    public void setNPC(NPC npcin)
    {
        npc = npcin;
    }



    public string npc_response()   // more need to be added to account for all of the personailty types.  
    {
        if (question_style_text.Equals("Aggressive"))    // not reading aggressive
        {
            return (npc.aggressive_response);
        }
        else if (question_style_text.Equals("Violent"))
        {
            return (npc.violent_response);
        }
        else if (question_style_text.Equals("Threaten"))
        {
            return (npc.threaten_response);
        }
        else 
        {
            return (npc.kind_response);
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
                speachbox.text = "how would you like to interact:";
                // Add the new button for picking how to interact with the npc 
                question.transform.Translate(0,57,0);
                accusebutt.transform.Translate(0,57,0);

            }

        }
        else
        {
            speachbox.text = npc.name + ": " + npc.dont_interact_response;
            npc = null;
        }
        
    }






    public void pick_question() // if the user clicks on question 
        
    {
        speachbox.text = "select questioing method:";
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
        questioingtype1.transform.Translate(0, 57, 0);
        questioingtype2.transform.Translate(0, 57, 0);
        questioingtype3.transform.Translate(0, 57, 0);
        questioingtype1.GetComponentInChildren<Text>().text = player.Personailty.type1();
        questioingtype2.GetComponentInChildren<Text>().text = player.Personailty.type2();
        questioingtype3.GetComponentInChildren<Text>().text = player.Personailty.type3();
    }





    public void questioing_style1()
    {
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype1;
        speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question1();
        speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
        check_okay_to_interact();
        npc = null;
    }



    public void questioing_style2()
        {
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype2;
        speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question2();
        speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
        check_okay_to_interact();
        npc = null;
        }

    public void questioning_style3()

        {
        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype3;
        speachbox.text = "Detective " + player.Name + ": "  + player.Personailty.Question3();
        speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
        check_okay_to_interact();
        npc = null;
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
