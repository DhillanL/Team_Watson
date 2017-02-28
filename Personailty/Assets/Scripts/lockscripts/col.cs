using UnityEngine;
using System.Collections;

public class col : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D Col)
    {
        //Debug.Log("col");
        int new_speed = -1 * (Col.GetComponent<speed>().get_speed());
        //Debug.Log(new_speed);
        Col.GetComponent<Rigidbody2D>().velocity = new Vector2(new_speed, 0);
        Col.GetComponent<speed>().set_speed(new_speed);
    }


    
}
