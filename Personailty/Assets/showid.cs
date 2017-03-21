using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showid : MonoBehaviour {

    public Text display;


    public void swap_ID()
    {
        if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1)
        {
            display.text = "Player1";
        } else
        {
            display.text = "Player2";
        }
    }

	// Use this for initialization
	void Start () {
        swap_ID();
	
	}

}
