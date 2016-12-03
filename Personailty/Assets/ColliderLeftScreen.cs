using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderLeftScreen : MonoBehaviour {

    public GameObject gamemanager;

    void OnTriggerEnter2D(Collider2D Col)
    {
        Vector3 starting_pos_left = new Vector3(155, -20, 0);

        string col_tag = Col.gameObject.tag;
        string room = SceneManager.GetActiveScene().name;
        Debug.Log("touch");
        Debug.Log(col_tag);

        if (col_tag.Equals("Player"))
        {
            
            if (room.Equals("Room7"))
            {
                gamemanager.GetComponent<gameManager>().load_meetingroom(); // load the meeting room (scencename - Room3)
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Room5"))
            {
                gamemanager.GetComponent<gameManager>().load_upstairslecture(); // load the upsairs lecture hall (scenename - Room 7 )
                Col.transform.position = starting_pos_left;
            }
            else if ( room.Equals("Room4"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH2(); // load second main RCH room (scenename - Screen3 )
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Screen3"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH1(); // (scenename - Screen2 )
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Screen2"))
            {
                gamemanager.GetComponent<gameManager>().load_outside_lakes(); // (scenename - room6)
                Col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Room6"))
            {
                gamemanager.GetComponent<gameManager>().load_outside_bottombalcony(); // (scenename - Room8)
                Col.transform.position = starting_pos_left;
            } else
            {
                Debug.Log("nope");
            }
                

        }
    }



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
