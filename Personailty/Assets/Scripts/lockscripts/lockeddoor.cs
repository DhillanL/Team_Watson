using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class lockeddoor : MonoBehaviour {
   

     void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_lockedroom();
            
        }

    }

}
