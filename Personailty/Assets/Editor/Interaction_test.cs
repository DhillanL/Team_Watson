using UnityEngine;
using System.Collections;
using NUnit.Framework;

[TestFixture]
public class Interaction_test
{

    [Test]
    public void player_personailty()
    {
        Personality_player personality = new Personality_player();
        personality.setintro("testintro");

        Assert.AreEqual(personality.Intro(),"testintro");
    }

    [Test]
    public void interaction()
    {
        


    }





}
