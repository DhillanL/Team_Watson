using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class clue: MonoBehaviour{
	public string name;
	public string NPC = null;
	//public scene location; // room type -- room will be of type scene
	public bool is_visiable = false;
	public bool is_bloody = false;
	public string NPC_text = null;
	//public scene[] spawnable_rooms = new scene[10];
	public Sprite look;

	public GameObject Interaction;
	public GameObject me;


	public string getName(){
		return name;
	}
	public void getInfo(){  
	}
	public string getNPC(){
		return NPC;
	}
	public void getLocation(){
		//return location;
	}
	//public string getInfo(){
	//}
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	void Update () {

	}
}


