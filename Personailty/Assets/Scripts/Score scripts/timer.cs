using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

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

	public float getTime() {
		return timer_seconds;
	}

    void Update()
	{
		if (SceneManager.GetActiveScene().name == "casefile") {
			timer_seconds = 0;
		}  else {
			timer_seconds += Time.deltaTime;
		}
	}
}
