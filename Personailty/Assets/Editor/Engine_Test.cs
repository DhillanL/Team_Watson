using NUnit.Framework;
using UnityEngine;
using UnityEditor;

[TestFixture]
public class Engine_Test
{


    [Test]
    public void Crime_Test()
    {
        CreateCrime Crime1 = new CreateCrime();

        Crime1.murder7 = "Valid";

        Crime1.Set_Murder(6);

        var value = Crime1.get_murder();

        Debug.Log(value);

        Assert.AreEqual(value, Crime1.murder7);
    }

    [Test]
    public void Character_Test()
    {
    	createPersonalitys person1 = new createPersonalitys();

    	var values = person1.getGoodCop();

    	var cop_name = values.type1();

    	Debug.Log(cop_name);

    	Assert.AreEqual(cop_name,"Kind");
    }
    [Test]
    public void NPC_Test()
    {
    	CreateNPC npc1 = new CreateNPC();

    	NPC Tonald = new NPC();
    	NPC Bernard = new NPC();
    	NPC George = new NPC();
    	NPC Ethan = new NPC();
    	NPC Ryan = new NPC();
    	NPC Zoe = new NPC();
    	NPC Alice = new NPC();
    	NPC Sophie = new NPC();
    	NPC Stephen = new NPC();
    	NPC Robert = new NPC();

    	npc1.Tonald_Dump = Tonald;
    	npc1.Bernard_lowe = Bernard;
    	npc1.George_allen = George;
    	npc1.Ethan_hawk = Ethan;
    	npc1.Ryan_Smith = Ryan;
    	npc1.Zoe_Williams = Zoe;
    	npc1.Alice_Davis = Alice;
    	npc1.Sophie_Aaron = Sophie;
    	npc1.Stephen_Brown = Stephen;
    	npc1.Robert_Henry = Robert;

    	npc1.makelst();

    	Debug.Log(npc1.npc_list_);

    	Assert.AreEqual(Tonald.room,"Yes");

    }
    [Test]
    public void NPC_Death_Test()
    {
    	CreateNPC npc1 = new CreateNPC();

    	NPC Tonald = new NPC();

    	npc1.Tonald_Dump = Tonald;

    	Tonald.isMurder();

    	Assert.IsTrue(Tonald.is_muderer);

    }
    [Test]
    public void interactions_Test()
    {
    	NPC Tonald = new NPC();

    	Tonald.aggressive_response = "How dare you";

    	Interaction interact1 = new Interaction();

    	interact1.npc = Tonald;

    	interact1.question_style_text = "Aggressive";

    	var value2 = interact1.npc_response();

    	Debug.Log(value2);

    	Assert.AreEqual(Tonald.aggressive_response,value2); 

    }

}



 

    // other tests :
    //            check_okay_to_interact - Interaction? requires npc/player and interaction class 
    //            shuffle list - CreateNPC
    //            set Room based on shuffle list - CreateNPC
    //            setCluesInGame - createClues
    //            addCLue -Logbok
    //            any set personailty - Personailty_player 



