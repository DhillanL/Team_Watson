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

    	Personality_player pp1 = new Personality_player();

    	var values = person1.getGoodCop();

    	var cop_name = values.type1();

    	Debug.Log(cop_name);

    	Assert.AreEqual(cop_name,"Kind");
    }

}



 

    // other tests :
    //            check_okay_to_interact - Interaction? requires npc/player and interaction class 
    //            shuffle list - CreateNPC
    //            set Room based on shuffle list - CreateNPC
    //            setCluesInGame - createClues
    //            addCLue -Logbok
    //            any set personailty - Personailty_player 



