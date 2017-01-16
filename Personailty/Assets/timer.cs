using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    public GameObject gameman;

    float timer_seconds = 0;
    float timer_mins = 0;
    bool test = true;


    public void testFalse()
    {
        test = false;
    }

    public void testTrue()
    {
        test = true;
    }


    void Update()
    {
        if (test)
        {
            timer_seconds += Time.deltaTime;

            if (timer_seconds > 59)
            {
                timer_mins++;
                timer_seconds = 0;

            }

            if (gameman == null)
            {
                gameman = GameObject.FindWithTag("gamemanager");
            }

            gameman.GetComponent<gameManager>().updatetime(timer_seconds, timer_mins);    // updates the time in the gameman

        }

    }


    void OnGUI()
    {
        GUI.Box(new Rect(1000, 595, 80, 30), ""  + timer_mins.ToString() +" : "  + "" + timer_seconds.ToString("00"));
    }





}
