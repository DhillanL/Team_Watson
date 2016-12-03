using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderRight : MonoBehaviour {

    public GameObject gamemanager;

    void OnTriggerEnter2D(Collider2D Coll)
    {

        Vector3 starting_pos_right = new Vector3(-155, -20, 0);

        string col_tag = Coll.gameObject.tag;
        string room = SceneManager.GetActiveScene().name;
        
        if (col_tag.Equals("Player"))
        {    
            if (room.Equals("Room7"))
            {
                gamemanager.GetComponent<gameManager>().load_lakehousebalcony(); // load the balcony (Scenename - Rom5)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room3"))
            {
                gamemanager.GetComponent<gameManager>().load_upstairslecture(); // (SceneName - Room7)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room8"))
            {
                gamemanager.GetComponent<gameManager>().load_outside_lakes(); //(Sccenename - room6)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Screen3"))
            {
                gamemanager.GetComponent<gameManager>().load_kitchen(); // (scenename - Room4 )
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Screen2"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH2(); // (Scenename - Screen3)
                Coll.transform.position = starting_pos_right;
            }
            else if (room.Equals("Room6"))
            {
                gamemanager.GetComponent<gameManager>().load_RCH1(); // (scenename - Screen2)
                Coll.transform.position = starting_pos_right;
            } else
            {
                ;
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
