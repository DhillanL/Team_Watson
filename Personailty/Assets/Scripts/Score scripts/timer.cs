using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	// times the playthough -- used to calculate the score

	public static timer instance = null;

	void Awake () {  //Makes this a singleton class on awake
		if (instance == null) { //Does an instance already exist?
			instance = this;	//If not set instance to this
		} else if (instance != this) { //If it already exists and is not this then destroy this
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject); //Set this to not be destroyed when reloading scene
	}

	public float timer_seconds = 0;

	public float getTime() { // returns the seconds elapsed since starting the game
		return timer_seconds;
	}

	// __NEW__ADDITION__
    void Update()
	{
		if (SceneManager.GetActiveScene().name == "casefile") { // so that timer_seconds is reset at the start of each playthough
			timer_seconds = 0;
		}  else {
			timer_seconds += Time.deltaTime; // add the time time spent on previous frame in seconds
		}
	}
}
