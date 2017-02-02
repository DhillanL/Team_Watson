using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    public GameObject gameman;

    public static float timer_seconds = 0;

    void Update()
	{
		timer_seconds += Time.deltaTime;
	}

    void OnGUI()
    {
        GUI.Box(new Rect(1000, 595, 80, 30), timer_seconds.ToString("00"));
    }

}
