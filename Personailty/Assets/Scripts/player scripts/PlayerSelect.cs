using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// script addded to the player selection screen which allows all of the button pressing to happen for selecting the personialtes 
// will chnage the name and personality as selcted by the player 
// once the finish button is pressed it will call transfer_info()

public class PlayerSelect : MonoBehaviour {

    public string Name;   // Name of the player 
    public InputField Namein;   //name inputed of the player 
   
    public Personality_player personality;    // personailty of the player 
    public int person_int = 0;
    
    public Button goodcopbutton;   // imports all buttons from scene 
    public Button badcopbutton;    
    public Button smartcopbutton;  
    public Button dumbcopbutton;
    public Button trustycopbutton;
    public Button suspicouscopbutton;

	private bool personality_selected = false;
  
    public Button Finish;    // button pressed when all selections are made

    public GameObject gameMan;       //game object of the dataholder object 
    public gameManager data;         //temp holder for data

    public GameObject createperson;                     // used to get the personailty wanted by the player 
    public createPersonalitys personalitycreate;        // refernce of the script createPersonailtys 

    public GameObject characterpreview;
    public Sprite goodcopsprite;    // sprites to be displayed!
    public Sprite badcopsprite;
    public Sprite smartcopsprite;
    public Sprite dumbcopsprite;
    public Sprite trustycopsprite;
    public Sprite suspiciouscopsprite;



    // gets the personailty selected by the user depending on the color of the boxes selected --> when the finish button is pressed 

    public void getPersonality()
    {
        personalitycreate = createperson.GetComponent<createPersonalitys>();

        if (badcopbutton.image.color.Equals(Color.red))
        {
            personality = personalitycreate.getBadCop();              // sets personality as bad cop
            
        }
        else if (goodcopbutton.image.color.Equals(Color.red))
        {
            personality = personalitycreate.getGoodCop();             // sets personality as good cop
            
        }
        else if (smartcopbutton.image.color.Equals(Color.red))
        {
            personality = personalitycreate.getSmartCop();            // sets personality as smart cop
            
        }
        else if (dumbcopbutton.image.color.Equals(Color.red))
        {
            personality = personalitycreate.getDumbCop();             // sets personality as dumb cop
            
        }
        else if (trustycopbutton.image.color.Equals(Color.red))
        {
            personality = personalitycreate.getTrustyCop();           // sets personality as trusting cop
            
        }
        else if (suspicouscopbutton.image.color.Equals(Color.red))
            personality = personalitycreate.getSuspCop();             // sets personality as suspicious cop
            
        
    }





    // changing the colour of the buttons depedning on whats clicked 


    public void GoodcopColor()                                     // turns goodcop red
    {
        set_character_preview(goodcopsprite);
        badcopbutton.image.color = Color.white;
        goodcopbutton.image.color = Color.red;
        smartcopbutton.image.color = Color.white;
        dumbcopbutton.image.color = Color.white;
        trustycopbutton.image.color = Color.white;
        suspicouscopbutton.image.color = Color.white;
        person_int = 2;
    }

    public void BadcopColor()                                        // turns badcop red
    {
        set_character_preview(badcopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.red;
        smartcopbutton.image.color = Color.white;
        dumbcopbutton.image.color = Color.white;
        trustycopbutton.image.color = Color.white;
        suspicouscopbutton.image.color = Color.white;
        person_int = 1;
    }

    public void SmartcopColor()
    {
        set_character_preview(smartcopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.white;
        smartcopbutton.image.color = Color.red;
        dumbcopbutton.image.color = Color.white;
        trustycopbutton.image.color = Color.white;
        suspicouscopbutton.image.color = Color.white;
        person_int = 3;
    }

    public void DumbcopColor()
    {
        set_character_preview(dumbcopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.white;
        smartcopbutton.image.color = Color.white;
        dumbcopbutton.image.color = Color.red;
        trustycopbutton.image.color = Color.white;
        suspicouscopbutton.image.color = Color.white;
        person_int = 4;
    }

    public void TrustycopColor()
    {
        set_character_preview(trustycopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.white;
        smartcopbutton.image.color = Color.white;
        dumbcopbutton.image.color = Color.white;
        trustycopbutton.image.color = Color.red;
        suspicouscopbutton.image.color = Color.white;
        person_int = 5;
    }

    public void SuspcopColor()
    {
        set_character_preview(suspiciouscopsprite);
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.white;
        smartcopbutton.image.color = Color.white;
        dumbcopbutton.image.color = Color.white;
        trustycopbutton.image.color = Color.white;
        suspicouscopbutton.image.color = Color.red;
        person_int = 6;
    }


    public void set_character_preview(Sprite sprite)
    {
        characterpreview.GetComponent<SpriteRenderer>().sprite = sprite;
    }



    // transfering data to gamemanager 

    public void transfer_personality()  // transfers the personailty into the gameManger script holding the static variables used in all scenes.   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadPersonailty(personality); // load personality into the gameManager
        data.loadpersonint(person_int);
    }
    public void transfer_srite()  // transfers the sprite   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadSprite(characterpreview.GetComponent<SpriteRenderer>().sprite);   //load with the sprite 
    }







    // WHEN FINSIH IS HIT 

    public void uploadname()     //set the name to what the user typed in and transfer it to gamManager 
    {

		// set name to what the user inputs
		gameManager.Name = Name; 
      // transfer the name into game manager 
    }


    public void setPersonality()   // get personailty and transfer data         
    {
        getPersonality();          // check which personailty is selected and set that one 
        transfer_personality();    // transfer the data to game manager 
        transfer_srite();          // also transfer the look of the detecttive
    }



	public void SetPersonalitySelected(){
		personality_selected = true;
	}
		
	
	// Update is called once per frame
	void Update () {

		Name = Namein.text;

		if (Name != "" && personality_selected) {
			Finish.interactable = true;
		} else {
			Finish.interactable = false; 
		}
	
	}
}
