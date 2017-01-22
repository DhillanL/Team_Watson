using UnityEngine;
using System.Collections;
using NUnit.Framework;

[TestFixture]
public class Interaction_test
{

    [Test]
    public void clues()
    {
        clue clue1 = new clue();
        clue clue2 = new clue(); 
        clue clue3 = new clue();
        clue clue4 = new clue();
        clue clue5 = new clue();
        clue clue6 = new clue();
        clue clue7 = new clue();
        clue clue8 = new clue();

        createClue createclues = new createClue();
        createclues.clue_1 = clue1;
        createclues.clue_2 = clue2;
        createclues.clue_3 = clue3;
        createclues.clue_4 = clue4;
        createclues.clue_5 = clue5;
        createclues.clue_5 = clue5;
        createclues.clue_6 = clue6;
        createclues.verbal_clue_7 = clue7;
        createclues.verbal_clue_8 = clue8;

        createclues.make_clues_crime_1();

       
        Assert.AreNotEqual(clue1.getName(), null);

    }

    [Test]
    public void NPC_answer()
    {
        NPC npc = new NPC();
        Interaction inter = new Interaction();
        string response;
        string testresponse;
        string[] question_style = { "Aggressive", "Violent" };
        int x = Random.Range(0, 2);

        npc.aggressive_response = "agg_res";
        npc.violent_response = "vio_res";

        if (x==0)
        {
            testresponse = npc.aggressive_response;
        } else
        {
            testresponse = npc.violent_response;
        }
        
        inter.question_style_text = question_style[x];
       
        inter.setNPC(npc);
        response = inter.npc_response();

        Assert.AreEqual(response,testresponse);

    }

    





}
