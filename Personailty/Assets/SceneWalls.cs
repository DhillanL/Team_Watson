using UnityEngine;
using System.Collections;

public class SceneWalls : MonoBehaviour {

    public Camera maincam;

    public BoxCollider2D leftwall;
    public BoxCollider2D rightwall;

    private Vector3 startposleft = new Vector3(-185, 11, 0);
    private Vector3 startposright = new Vector3(185, 11, 0);



	// Use this for initialization
	void Start () {
        leftwall.size = new Vector2(1f, maincam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftwall.transform.position = startposleft;

        rightwall.size = new Vector2(1f, maincam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightwall.transform.position = startposright;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
