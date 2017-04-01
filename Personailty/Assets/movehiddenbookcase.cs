using UnityEngine;
using System.Collections;

public class movehiddenbookcase : MonoBehaviour {

    public Rigidbody2D rb2D;
    private bool been_opened = false;

    public GameObject hidden_door;


    // Use this for initialization
    void Start () {

        rb2D = GetComponent<Rigidbody2D>();

    }

    void OnMouseDown()
    {
        if (!been_opened)
        {
            StartCoroutine(move_case());
        }

    }

    IEnumerator move_case()
    {
        rb2D.velocity = new Vector2(-17, 0);
        yield return new WaitForSeconds(2);
        rb2D.velocity = new Vector2(0, 0);
        been_opened = true;
        hidden_door.GetComponent<lockeddoor>().is_visible();
    }



}
