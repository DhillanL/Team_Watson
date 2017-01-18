using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderUpDown : MonoBehaviour {

    public GameObject gameman;


    void OnTriggerStay2D(Collider2D col) // When up is pressed near a door, the player is moved to a new room
    {
        string room = SceneManager.GetActiveScene().name;


        Vector3 starting_pos_left = new Vector3(-155, -20, 0); // Player position reset

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (room.Equals("Screen2"))
            {
                gameman.GetComponent<gameManager>().load_meetingroom(); // go upstiars to the meeting room
                col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Screen3"))
            {
                gameman.GetComponent<gameManager>().load_upstairslecture(); // go upstiars to the lecture room 
                col.transform.position = starting_pos_left;
            } 
            else if (room.Equals("Room7"))
            {
                gameman.GetComponent<gameManager>().load_RCH2(); // load second rch room go downstaris 
                col.transform.position = starting_pos_left;
            }
            else if (room.Equals("Room3"))
            {
                gameman.GetComponent<gameManager>().load_RCH1(); // do downstairs to rch 1 
                col.transform.position = starting_pos_left;
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
