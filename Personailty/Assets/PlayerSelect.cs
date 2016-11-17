using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// scirpt addded to the player selection screen which allows all of the button pressing to happen for selecting the personialtes 
// will chnage the name and personality as selcted by the player 
// once the finish button is pressed it will call transfer_info()

public class PlayerSelect : MonoBehaviour {

    public string Name;
    public InputField Namein;
   
    public Personality_player personality;
    
    public Button goodcopbutton;
    public Button badcopbutton;
    public Button Finish;

    public GameObject gameMan;       //game object of the dataholder object 
    public gameManager data;         //temp holder for data

    public GameObject createperson;                     // used to get the personailty wanted by the player 
    public createPersonalitys personailtycreate;        // refernce of the script createPersonailtys 

    public GameObject characterpreview;
    public Sprite goodcopsprite;
    public Sprite badcopsprite;



    // gets the personailty selected by the user depending on the color of the boxes selected

    public void getPersonality()
    {
        personailtycreate = createperson.GetComponent<createPersonalitys>();

        if (badcopbutton.image.color.Equals(Color.red))
        {
            personality = personailtycreate.getBadCop();    // sets personailty as bad cop
        } else
        {
            personality = personailtycreate.getGoodCop();    // sets personailty as good cop
        }
        
    }





    // changing the colour of the buttons depedning on whats clicked 


    public void GoodcopColor()                                     // turns goodcop red
    {
        set_character_preview(goodcopsprite);
        if (badcopbutton.image.color.Equals(Color.white))
        {
            goodcopbutton.image.color = Color.red;
            
        }

        badcopbutton.image.color = Color.white;
        goodcopbutton.image.color = Color.red;
    }

    public void BadcopColor()                                        // turns badcop red
    {
        set_character_preview(badcopsprite);
        if (goodcopbutton.image.color.Equals(Color.white))
        {
            badcopbutton.image.color = Color.red;
            
        }
        goodcopbutton.image.color = Color.white;
        badcopbutton.image.color = Color.red;
    }

    public void set_character_preview(Sprite sprite)
    {
        characterpreview.GetComponent<SpriteRenderer>().sprite = sprite;
    }



    // transfering data to gamemanager 

    public void transfer_name()  // transfers the name and personailty into the gameManger script holding the static variables used in all scenes.   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadName(Name); // load name into the gameManager
    }
    public void transfer_personality()  // transfers the name and personailty into the gameManger script holding the static variables used in all scenes.   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadPersonailty(personality); // load name into the gameManager
    }
    public void transfer_srite()  // transfers the sprite   
    {
        data = gameMan.GetComponent<gameManager>();
        data.loadSprite(characterpreview.GetComponent<SpriteRenderer>().sprite);   //load with the sprite 
    }







    // WHEN FINSIH IS HIT 

    public void uploadname()     //set the name to what the user typed in and transfer it to gamManager 
    {
        Name = Namein.text;
        transfer_name();
    }


    public void setPersonality()   // get personailty and transfer data         
    {
        getPersonality();
        transfer_personality();
        transfer_srite();
    }










	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
