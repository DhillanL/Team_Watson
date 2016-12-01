using UnityEngine;
using System.Collections;

public class SceneBorders : MonoBehaviour
{

    public Camera mainCam;

    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;


    void Start()
    {

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
    }

}
