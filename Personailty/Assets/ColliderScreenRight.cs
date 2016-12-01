using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderScreenRight : MonoBehaviour {

    public Transform Player;

	void OnCollisionEnter2D (Collision2D Collider)
    {
        string room = SceneManager.GetActiveScene().name;
        if (Collider.gameObject.tag == "Player")
        {
            if (room == "Screen2")
            {
                SceneManager.LoadScene("Screen3");
                Player.transform.position = new Vector3(-60, -21, 0);
            }
            else if (room == "Screen3")
            {
                SceneManager.LoadScene("Room5");
                Player.transform.position = new Vector3(-60, -21, 0);
            }
            else if (room == "Room5")
            {
                SceneManager.LoadScene("Room7");
                Player.transform.position = new Vector3(-60, -21, 0);
            }
            else if (room == "Room8")
            {
                SceneManager.LoadScene("Room6");
                Player.transform.position = new Vector3(-60, -21, 0);
            }
            else if (room == "Room6")
            {
                SceneManager.LoadScene("Screen2");
                Player.transform.position = new Vector3(-60, -21, 0);
            }
            else if (room == "Room4")
            {
                SceneManager.LoadScene("Screen3");
                Player.transform.position = new Vector3(-60, -21, 0);
            }

        }
    }
}
