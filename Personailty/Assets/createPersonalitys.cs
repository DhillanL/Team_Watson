using UnityEngine;
using System.Collections;

public class createPersonalitys : MonoBehaviour {

    // script which is used to create all of the personailtes that the playe can be //
    // each is of type Personailty player, this is just the scipt where they are all craeted // 

    public GameObject gameman;
    public gameManager name;
    string Name = "";     //player name 

    public void getname()      // gets the name of the player 
    {
        name = gameman.GetComponent<gameManager>();
        Name = name.getName();
    }


   static public Personality_player badCop = new Personality_player();
   static public Personality_player goodCop = new Personality_player();




    // BAD COP PERSONAILTY  // 

    public void makebadcop()
    {
        getname();
        badCop.Name = Name;
        badCop.setintro("My name is dective " + Name.ToString());
        badCop.settype1("Aggresive");
        badCop.set1("Tell me were you at the time of the murder?");  //aggresive
        badCop.settype2("Violent");
        badCop.set2("You tell me what you know");
        badCop.settype3("Threaten");
        badCop.set3("Tell me what you know or else...");
    }


    public Personality_player getBadCop( )
    {
        makebadcop();
        return badCop;
    }





    //      GOOD COP PERSONAILTY       //

    public void makegoodcop()
    {
        getname();
        goodCop.Name = Name;
        goodCop.setintro("Im a good gop called " + Name.ToString());
        goodCop.settype1("Kind");
        goodCop.set1("I'm here to help you catch who did this, did you see or hear anything?");  //aggresive
        goodCop.settype2("Sympthetic");
        goodCop.set2("im sorry to hear what happened, do you know aything that could help?");
        goodCop.settype3("Friendly");
        goodCop.set3("alrihgt mate what you know?");
    }



    public Personality_player getGoodCop()
    {
        makegoodcop();
        return goodCop;
    }









    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
