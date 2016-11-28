using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// scirpt addded to the player selection screen which allows all of the button pressing to happen for selecting the personialtes 
// will chnage the name and personality as selcted by the player 
// once the finish button is pressed it will call transfer_info()

public class PlayerSelect : MonoBehaviour {

    public string Name;   // Name of the player 
    public InputField Namein;   //name inputed of the player 
   
    public Personality_player personality;    // personailty of the player 
    
    public Button goodcopbutton;   // personailty type 
    public Button badcopbutton;    // personailty type 
  
    public Button Finish;    //buttton pressed when all selections are made

    public GameObject gameMan;       //game object of the dataholder object 
    public gameManager data;         //temp holder for data

    public GameObject createperson;                     // used to get the personailty wanted by the player 
    public createPersonalitys personailtycreate;        // refernce of the script createPersonailtys 

    public GameObject characterpreview;
    public Sprite goodcopsprite;    //looks for the personailtes 
    public Sprite badcopsprite;
    



    // gets the personailty selected by the user depending on the color of the boxes selected --> when the finish button is pressed 

    public void getPersonality()
    {
        personailtycreate = createperson.GetComponent<createPersonalitys>();

        if (badcopbutton.image.color.Equals(Color.red))
        {
            personality = personailtycreate.getBadCop();              // sets personailty as bad cop
        } else if (goodcopbutton.image.color.Equals(Color.red))
        {
            personality = personailtycreate.getGoodCop();             // sets personailty as good cop
        } 
        
    }





    // changing the colour of the buttons depedning on whats clicked 


    public void GoodcopColor()                                     // turns goodcop red
    {
        set_character_preview(goodcopsprite);
        badcopbutton.image.color = Color.white;
        goodcopbutton.image.color = Color.red;
    }

    public void BadcopColor()                                        // turns badcop red
    {
        set_character_preview(badcopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.red;
    }

 
    public void set_character_preview(Sprite sprite)
    {
        characterpreview.GetComponent<SpriteRenderer>().sprite = sprite;
    }



    // transfering data to gamemanager 

    public void transfer_name()  // transfers the name into the gameManger script holding the static variables used in all scenes.   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadName(Name); // load name into the gameManager
    }
    public void transfer_personality()  // transfers the personailty into the gameManger script holding the static variables used in all scenes.   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadPersonailty(personality); // load personality into the gameManager
    }
    public void transfer_srite()  // transfers the sprite   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadSprite(characterpreview.GetComponent<SpriteRenderer>().sprite);   //load with the sprite 
    }







    // WHEN FINSIH IS HIT 

    public void uploadname()     //set the name to what the user typed in and transfer it to gamManager 
    {
        Name = Namein.text;   // set name to what the user inputs 
        transfer_name();      // transfer the name into game manager 
    }


    public void setPersonality()   // get personailty and transfer data         
    {
        getPersonality();          // check which personailty is selected and set that one 
        transfer_personality();    // transfer teh data to game manager 
        transfer_srite();          // also transfer the look of the detecttive
    }










	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
