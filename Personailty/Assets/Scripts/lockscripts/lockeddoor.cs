using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class lockeddoor : MonoBehaviour {

    public bool visible = false;


     void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.W) && visible)
        {
            GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_lockedroom();
            GameObject.FindWithTag("turn").GetComponent<turnswitcher>().stop_loop();
            
        }

    }


    public void is_visible()
    {
        visible = true;
    }

}
