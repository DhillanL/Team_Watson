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
            if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().istwoplayeron())
            {
                GameObject.FindWithTag("turn").GetComponent<turnswitcher>().start_loop();
            }

        }

    }


    public void is_visible()
    {
        visible = true;
    }

}
