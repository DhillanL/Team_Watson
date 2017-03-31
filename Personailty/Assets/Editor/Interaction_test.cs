using UnityEngine;
using System.Collections;
using NUnit.Framework;
using UnityEngine.UI;

[TestFixture]
public class Interaction_test
{

    [Test]
    public void clues() // Create a list of clues and check that the clues are assigned to a value
    {
		//In the createclues.make_clues_crime_1() function commment out anything to do with sprites
        clue clue1 = new clue();
        clue clue2 = new clue(); 
        clue clue3 = new clue();
        clue clue4 = new clue();
        clue clue5 = new clue();
        clue clue6 = new clue();
        clue clue7 = new clue();
        clue clue8 = new clue();
		clue motive_clue = new clue ();	//Motive clue added to test

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
		createclues.motiveClue = motive_clue;

        createclues.make_clues_crime_1();
       
        Assert.AreNotEqual(clue1.getName(), null); // Test fails if a clue is empty

    }

    [Test]
    public void NPC_answer() // Check NPC responses to certain accusations
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

	//___NEW__ADDITION___
	[Test]
	public void NewClueObtainedCheckPositive(){
		//Checks that okay_to_interact is set to true if clue_count > stored clues
		Interaction inter = new Interaction();
		logbookparts.clue_count1 = 3;

		inter.npc = new NPC ();

		inter.npc.okay_to_interact = false;
		inter.npc.StoreNumOfClues (2);

		inter.NewClueObtainedCheck ();

		Assert.IsTrue (inter.npc.okay_to_interact);

	}

	//___NEW__ADDITION___
	[Test]
	public void NewClueObtainedCheckNegative(){
		//Should never occur unless code changed 
		//Checks that if okay_to_interact stays false if stored clues > clue_count
		Interaction inter = new Interaction();
		logbookparts.clue_count1 = 0;

		inter.npc = new NPC ();

		inter.npc.okay_to_interact = false;
		inter.npc.StoreNumOfClues (3);

		inter.NewClueObtainedCheck ();

		Assert.IsFalse (inter.npc.okay_to_interact);

	}

	//___NEW__ADDITION___
	[Test]
	public void NewClueObtainedCheckEqual(){ 
		//Tests that if clue_count == stored clues, okay_to_interact stays false
		Interaction inter = new Interaction();
		logbookparts.clue_count1 = 0;

		inter.npc = new NPC ();

		inter.npc.okay_to_interact = false;
		inter.npc.StoreNumOfClues (0);

		inter.NewClueObtainedCheck ();

		Assert.IsFalse(inter.npc.okay_to_interact);

	}
}
