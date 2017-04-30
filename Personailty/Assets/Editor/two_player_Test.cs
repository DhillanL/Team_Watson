using UnityEngine;
using System.Collections;
using NUnit.Framework;
using UnityEngine.UI;

[TestFixture]
public class two_player_Test
{

    [Test]
    public void Player_swaptag()
    {
        // set up two players and temp and set the tags to what they would be in the game 
        turnswitcher turn = new turnswitcher();
        GameObject player1 = new GameObject();
        GameObject player2 = new GameObject();
        GameObject tempholder = new GameObject();
        player1.tag = "Player";
        player2.tag = "Player2";
        tempholder.tag = "tempplayer";

        // call the procedure swap tags which is called when the turns switch the swap the tags of the players 
        turn.swaptags();

        // check that player2 now has the player tag 
        Assert.IsTrue(player2.tag == "Player");

    }

    [Test]
    public void move_player_offscreen()
    {
        // create the turnswitcher and a player gameobject
        turnswitcher turn = new turnswitcher();
        GameObject player = new GameObject();

        player.GetComponent<Transform>().position = new Vector3(100, 0, 100);

        // call the procedure to move the gameobject given off the screen to the pos (0,-200,0)
        turn.moveoffscreen(player);

        float ypos = player.GetComponent<Transform>().position.y;  // save the Y position of the player into the var ypos

        // checks that the new position of the player is (0,-200,0)
        Assert.IsTrue(ypos == -200);

    }

    [Test]
    public void Gamemanager_switching_player_turns_flag()
    {
        // create a game manager object to test the swaping player flag 
        gameManager gameman = new gameManager();

        // call the swap flag procedure 
        gameman.swap_players();

        // check that the flag has been set to two as the player has switched 
        Assert.IsTrue(gameman.get_player_turn() == 2);
    }

    [Test]
    public void Testing_player2_name()
    {
        // create a game manager object to test the swaping player flag 
        gameManager gameman = new gameManager();

        //set the var for the player name
        gameman.setplayer2name("test_name");

        Assert.IsTrue(gameman.getnameplayer2() == "test_name");

    }

    [Test]
    public void set_two_player_flag_test()
    {
        // create a game manager object to test the swaping player flag 
        gameManager gameman = new gameManager();

        // turn on the two player game flag 
        gameman.Twoplayeron();

        Assert.IsTrue(gameman.istwoplayeron() == true);

    }

    [Test]
    public void clue_found_by_both_players()
    {
        // create a clue that can be found by the players 
        clue clue = new clue();

        // set the clue so that it is found by both of the players 
        clue.is_found1 = true;
        clue.is_found2 = true;

        //assert that the clue has been found by both of the players
        Assert.IsTrue(clue.found_by_both() == true);

    }




}
