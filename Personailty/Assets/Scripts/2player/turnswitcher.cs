using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class turnswitcher : MonoBehaviour {

    public bool iswinner = false;
    public bool player1turn = true;

    IEnumerator swapturns()
    {
        while(!iswinner)
        {
            yield return new WaitForSeconds(30);
            switchplayertags();
            if (player1turn)
            {
                GameObject.FindWithTag("swap").GetComponent<Transform>().position = new Vector3(5,4,0);
                yield return new WaitForSeconds(5);
                GameObject.FindWithTag("swap").GetComponent<Transform>().position = new Vector3(4, 200, 0);

                GameObject.FindWithTag("Player").GetComponent<Transform>().position = GameObject.FindWithTag("Player2").GetComponent<Transform>().position;
                GameObject.FindWithTag("Player2").GetComponent<Transform>().position = new Vector3(0, -200, 0);

                loadroom();
            } 
        }
        
    }

    private void switchplayertags()
    {
        GameObject.FindWithTag("Player").tag = "tempplayer";
        GameObject.FindWithTag("Player2").tag = "Player";
        GameObject.FindWithTag("tempplayer").tag = "Player2";

    }

    private void loadroom()
    {
        gameManager gameman = GameObject.FindWithTag("gamemanager").GetComponent<gameManager>();
        string room = GameObject.FindWithTag("Player").GetComponent<player>().PastScene;
        if (room == "Room3")
        {
            gameman.load_meetingroom();
        }
        else if (room == "Room4")
        {
            gameman.load_kitchen();
        }
        else if (room == "Room5")
        {
            gameman.load_lakehousebalcony();
        }
        else if (room == "Room6")
        {
            gameman.load_outside_lakes();
        }
        else if (room == "Room7")
        {
            gameman.load_upstairslecture();
        }
        else if (room == "Room8")
        {
            gameman.load_outside_bottombalcony();
        } else if (room == "screen2")
        {
            gameman.load_RCH1();
        } else if (room == "Screen3")
        {
            gameman.load_RCH2();
        }


    }

	// Use this for initialization
	void Start () {
        StartCoroutine(swapturns());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
