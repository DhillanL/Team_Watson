using UnityEngine;
using System.Collections;

public class MapCall : MonoBehaviour {

    /* Mapcall is a scirpt used to bring the map onto the screen when the map icon in pressed on the GUI. 
     * */

    private Vector3 finish_pos = new Vector3(-1,22,1);  // vector relates to a point on hte screen for the map to move to

    void Awake() // means the object will not be destroyed when a new scene is loaded 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void OnMouseDown()  // function is used when ever the object this script is atached to is clicked (map icon)
    {
        
        GameObject.FindWithTag("map").GetComponent<Map>().transform.position = finish_pos;  // move the map 
        GameObject.FindWithTag("Player").GetComponent<player>().walkF();  // make it so the player can not move while the map is on the screen
    }

    
}
