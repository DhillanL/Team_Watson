using UnityEngine;
using System.Collections;

public class createPersonalitys : MonoBehaviour {

    /* script which is used to create all of the personailtes that the playe can be 
     each is of type Personailty player, all of the attributes and questions are made here */

    public GameObject gameman;
    public gameManager NAme;
    string Name = "";         //player name 

    public void getname()    // gets the name of the player from the game manager 
    {
        NAme = gameman.GetComponent<gameManager>();
        Name = NAme.getName();
    }

    // static variables for the personialtes of the player 
   static public Personality_player badCop = new Personality_player();
   static public Personality_player goodCop = new Personality_player();
   static public Personality_player smart = new Personality_player();
   static public Personality_player dumb = new Personality_player();
   static public Personality_player trust = new Personality_player();
   static public Personality_player susp = new Personality_player();




    //      BAD COP PERSONAILTY      // 

    public void makebadcop()
    {
        getname();
        badCop.Name = Name;
        badCop.setintro("My name is dective " + Name.ToString());
        badCop.settype1("Aggressive"); 
        badCop.set1("Tell me where you were att he time of the murder or else...");  
        badCop.settype2("Violent");
        badCop.set2("Im losing my patience with this place, tell me what you know");
        badCop.settype3("Threaten");
        badCop.set3("Tell me what you know or else...");
		
    }


    public Personality_player getBadCop( )
    {
        makebadcop();
        return badCop;
    }


    //      GOOD COP PERSONALITY       //

    public void makegoodcop()
    {
        getname();
        goodCop.Name = Name;
        goodCop.setintro("Hi there my name is detective " + Name.ToString() + "how are you today?");
        goodCop.settype1("Kind");
        goodCop.set1("I'm here to help you catch who did this, did you see or hear anything friend?");  //aggresive
        goodCop.settype2("Sympthetic");
        goodCop.set2("Im sorry to hear what happened, do you know aything that could help?");
        goodCop.settype3("Friendly");
        goodCop.set3("We're both on the same side so please, how well did you know the victim?");
    }



    public Personality_player getGoodCop()
    {
        makegoodcop();
        return goodCop;
    }


    //      SMART COP PERSONALITY      //  

    public void makesmartcop()
    {
        getname();
        smart.Name = Name;
        smart.setintro("Why hello there I am very smart, call me Detective " + Name.ToString());
        smart.settype1("Friendly");
        smart.set1("How well did you know the victim? Great shoes by the way");
        smart.settype2("Cunning");
        smart.set2("I heard from someone else they think it was you");
        smart.settype3("Aggresive");
        smart.set3("Tell me where you were att he time of the murder or else...");
    }

    public Personality_player getSmartCop()
    {
        makesmartcop();
        return smart;
    }

    //      DUMB COP PERSONALITY       //

    public void makedumbcop()
    {
        getname();
        dumb.Name = Name;
        dumb.setintro("Hi there, my name detective " + Name.ToString());
        dumb.settype1("Kind");
        dumb.set1("Hi friend, any idea what happened?");
        dumb.settype2("Violent");
        dumb.set2("TELL ME WHAT YOU KNOW");
        dumb.settype3("Threaten");
        dumb.set3("Tell me what happened here or I will hurt you...");
    }

    public Personality_player getDumbCop()
    {
        makedumbcop();
        return dumb;
    }

    //      TRUSTING COP PERSONALITY   //

    public void maketrustycop()
    {
        getname();
        trust.Name = Name;
        trust.setintro("Hello there, my name is " + Name.ToString() + "and i am here to help you");
        trust.settype1("Sympathetic");
        trust.set1("Im sorry to hear what happened, I can offer you any help if you can give me any info?");
        trust.settype2("Mean");
        trust.set2("I know you are trying to help but im getting impatient so tell me what you know, you loko shifty");
        trust.settype3("Kind");
        trust.set3("Im here to help, so please if you know something, tell me friend");
    }

    public Personality_player getTrustyCop()
    {
        maketrustycop();
        
        return trust;
    }



    //      SUSPICIOUS COP PERSONALITY   //

    public void makesuspcop()
    {
        getname();
        susp.Name = Name;
        susp.setintro("Hello there, my name is " + Name.ToString() + "and i am here to question you");
        susp.settype1("Cunning");
        susp.set1("i heard that you have something to do with this, anything to say?");
        susp.settype2("Violent");
        susp.set2("I havent got time for this, do you know something or not?!");
        susp.settype3("Mean");
        susp.set3("I dont like the look of you, I've been doing this a while so i pick out the criminals");
    }

    public Personality_player getSuspCop()
    {
        makesuspcop();
        return susp;
    }




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
