﻿using NUnit.Framework;
using UnityEngine;
using UnityEditor;

[TestFixture]
public class Engine_Test
{


    [Test]
    public void Crime_Test() // A simple test for the create crime class
    {
        CreateCrime Crime1 = new CreateCrime();

        Crime1.murder7 = "Valid";

        Crime1.Set_Murder(6);

        var value = Crime1.get_murder();

        Debug.Log(value);

        Assert.AreEqual(value, Crime1.murder7); // Create an instance of a crime and make sure it is set to the correct murder scenario when set_murder is called
    }

    [Test]
    public void Character_Test() // Set the cop type to good cop and check that you interact as a good cop
    {
    	createPersonalitys person1 = new createPersonalitys();

    	var values = person1.getGoodCop();

    	var cop_name = values.type1();

    	Debug.Log(cop_name);

    	Assert.AreEqual(cop_name,"Kind"); // The first question option should always be kind when good cop
    }
    [Test]
    public void NPC_Test()
    {
    	CreateNPC npc1 = new CreateNPC();

    	NPC Tonald = new NPC();

    	Tonald.is_Victim();

    	Assert.IsTrue(Tonald.is_victim);

    }
    [Test]
    public void NPC_Death_Test() // Check that an NPC can be assigned to be the murderer
    {
    	CreateNPC npc1 = new CreateNPC();

    	NPC Tonald = new NPC();

    	npc1.Tonald_Dump = Tonald;

    	Tonald.isMurder();

    	Assert.IsTrue(Tonald.is_muderer); // Assign tonald to be the murderer and check if he is

    }
    [Test]
    public void interactions_Test() // Test interactions when talking to an NPC
    {
    	NPC Tonald = new NPC();

    	Tonald.aggressive_response = "How dare you";

    	Interaction interact1 = new Interaction();

    	interact1.npc = Tonald;

    	interact1.question_style_text = "Aggressive";

    	var value2 = interact1.npc_response();

    	Debug.Log(value2);

    	Assert.AreEqual(Tonald.aggressive_response,value2); // Check that when you aggressively talk to an NPC, they gives you the aggressive response

    }

}




