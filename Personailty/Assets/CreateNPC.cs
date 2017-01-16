using UnityEngine;
using System.Collections;

public class CreateNPC : MonoBehaviour {

    /* script used to create all of the NPC's that will be used in the game, all of their responses to all of the posiible personailtes that the playe could be 
     * also will have the types of questioning that the npcs will not like and so will ignore the player from 
     * will also hold the look of the npc's */

    public gameManager Gameman;   //gamemanager

    public GameObject crime;

    public GameObject clues;

    // GAMEOBJECTS OF EACH OF THE NPCS 
    public GameObject Tonald;
    public GameObject Bernard;
    public GameObject George;
    public GameObject Ethan;
    public GameObject Ryan;
    public GameObject Zoe;
    public GameObject Alice;
    public GameObject Sophie;
    public GameObject Stephen;
    public GameObject Robert;


    // NPCS PF NPC TYPE WITH THEIR NAMES 
    public NPC Tonald_Dump ;    //TEST NAME 
    public NPC Bernard_lowe ;  // test name 
    public NPC George_allen;   // test name 
    public NPC Ethan_hawk ;    // test name 
	public NPC Ryan_Smith;
	public NPC Zoe_Williams;
	public NPC Alice_Davis;
	public NPC Sophie_Aaron;
	public NPC Stephen_Brown;
	public NPC Robert_Henry;

    // NPC LOOKS 
    public SpriteRenderer tonald_look; 
    public SpriteRenderer bernard_look;
    public SpriteRenderer george_look;
    public SpriteRenderer ethan_look;
	public SpriteRenderer ryan_look;
	public SpriteRenderer zoe_look;
	public SpriteRenderer alice_look;
	public SpriteRenderer sophie_look;
	public SpriteRenderer stephen_look;
	public SpriteRenderer robert_look;

    // lists for selecting a murder and a victim
    public NPC[] npc_list_ = new NPC[10];        
    public NPC[] npc_list_vic_ = new NPC[9];      // list with all npcs who are not the victim
    public NPC[] npc_list_mur_vic = new NPC[8];   // list without victim and murder

    // lists needed for creating the room allocation 
    public GameObject[] gameobjectlst_ = new GameObject[10];       
    public GameObject[] gameobjectlstshuffle_ = new GameObject[10];

    public Sprite dead; // sprite used to give the sprite for a dead chaarter to the selected npc

    public void setNCPS() // method to access the NPC script of each game object of the NPC so it can be modifed to make each one unique 
    {
        Tonald_Dump = Tonald.GetComponent<NPC>();
        tonald_look = Tonald.GetComponent<SpriteRenderer>();    // to set the look 

        Bernard_lowe = Bernard.GetComponent<NPC>();
        bernard_look = Bernard.GetComponent<SpriteRenderer>();   

        George_allen = George.GetComponent<NPC>();
        george_look = George.GetComponent<SpriteRenderer>();

        Ethan_hawk = Ethan.GetComponent<NPC>();
        ethan_look = Ethan.GetComponent<SpriteRenderer>();

		Ryan_Smith = Ryan.GetComponent<NPC>();
        ryan_look = Ryan.GetComponent<SpriteRenderer>();

        Zoe_Williams = Zoe.GetComponent<NPC>();
        zoe_look = Zoe.GetComponent<SpriteRenderer>();

        Alice_Davis = Alice.GetComponent<NPC>();
        alice_look = Alice.GetComponent<SpriteRenderer>();

        Sophie_Aaron = Sophie.GetComponent<NPC>();
        sophie_look = Sophie.GetComponent<SpriteRenderer>();

        Stephen_Brown = Stephen.GetComponent<NPC>();
        stephen_look = Stephen.GetComponent<SpriteRenderer>();

        Robert_Henry = Robert.GetComponent<NPC>();
        robert_look = Robert.GetComponent<SpriteRenderer>();
    }

	public void make_tonald()   // set of tonalds attibutes to make his personailty
	{
		// basic setup
		Tonald_Dump.Name =      "Tonald"; // HAS TO BE THE FIRST NAME ONLY AS IT MATCHES TE TAG OF THE PLAYER 
		Tonald_Dump.intro =     "Hello, Im' Tonald the manager of Ron Cooke Hub. I'll be happy to help in any way I can";
		tonald_look.sprite =    Tonald_Dump.look;    //look set from the sprite added to game object
		Tonald_Dump.he_she =    "he";  // he or she
        Tonald_Dump.initial =   "T.D";
        Tonald_Dump.man_woman = "man";
        Tonald_Dump.age = 52;

	    //Responses 
		Tonald_Dump.aggressive_response = "Or else what? go away detective";
		Tonald_Dump.violent_response =    "Okay, Okay calm down...I'm sorry detective but I dont know anything !";
		Tonald_Dump.threaten_response =   "DON'T THREATEN ME! who do you think ou are?! Dont bother talking to me again!";
        Tonald_Dump.kind_response =       "Well I haven't seen anything out of the ordinary";
        Tonald_Dump.friendly_response =   "I'm afiad I don't know anything, But please ask if you have any more questions";
        Tonald_Dump.sympthetic_response = "I cant belive whats happened, maybe we should build a wall to keep out criminals?";
        Tonald_Dump.cunning_response =    "Oooh yeah from who? I don't belive you I've done nothing";
        Tonald_Dump.mean_response =       "I dont like the Look of you either! Go away";
		
        // no more interaction set up 
        Tonald_Dump.dont_interact_response = "I have nothing else to say detective, Leave me alone";
        Tonald_Dump.dont_interact_if1 = Tonald_Dump.threaten_response;       // Tonald wont interact if he is questioned 'threaten or violent'
        Tonald_Dump.dont_interact_if2 = Tonald_Dump.violent_response;

        // clue responses 
        Tonald_Dump.clue_response1 = "Kind";  // if you are kind or cunning tonald will give away a clue if he has one 
        Tonald_Dump.clue_response2 = "Cunning";

        //incorrect accusation
        Tonald_Dump.incorect_accusation = "It wasn't me you fool! Dont talk to me anymore! ";
	}



	public void make_bernard()   // set bernards 
	{
		//basic setup
		Bernard_lowe.Name =      "Bernard";
		Bernard_lowe.intro =     "Hi I'm Bernard, the head chef here, If you need something to eat or drink pop by";
		bernard_look.sprite =    Bernard_lowe.look;
		Bernard_lowe.he_she =    "he";   // he or she
        Bernard_lowe.initial =   "B.L";
        Bernard_lowe.man_woman = "man";
        Bernard_lowe.age = 43;

		//responses
		Bernard_lowe.aggressive_response =  "I was in kitchen preparing dinner! I promoise, dont hurt me, Dont come back to me!";
		Bernard_lowe.violent_response =     "I'm sorry but I dont know anything! I'd tell you if I did. No point asking me anything else";
		Bernard_lowe.threaten_response =    "Please dont hurt me! I dont know anything! ";
		Bernard_lowe.kind_response =        "I'd tell you if I knew anything detective! I swear";
		Bernard_lowe.friendly_response =    "Sorry mate I've got nothing, didn't really speak to them";
		Bernard_lowe.sympthetic_response =  "Its terrible what happened, theres a killer around here somewhere";
        Bernard_lowe.cunning_response =     "What they are lying! I've done nothing wrong! ";
        Bernard_lowe.mean_response =        "No need to be rude to me detective";

		//no more interaction setup
		Bernard_lowe.dont_interact_response = "Go away detective! leave me alone";
        Bernard_lowe.dont_interact_if1 = Bernard_lowe.violent_response;
        Bernard_lowe.dont_interact_if2 = Bernard_lowe.aggressive_response;

        //clue response
        Bernard_lowe.clue_response1 = "Threaten";
        Bernard_lowe.clue_response2 = "Cunning";

        // incorrect accusation 
        Bernard_lowe.incorect_accusation = "INCORRECT ACCUSATION ";
	}


    // ADD OF THE NPCS BELOW STILL NEED TO BE FINSIHED // 


	public void make_George()
	{
        //basic setup
		George_allen.Name = "George";
		George_allen.intro = "Good Evening detective, I have lots of first-hand news from all around the world!";
		george_look.sprite = George_allen.look;
		George_allen.he_she = "he";
        George_allen.initial = "G.A";
        George_allen.man_woman = "man";
        George_allen.age = 28;

		//responses
		George_allen.aggressive_response = "I was getting ready for the ball tonight, alone";
		George_allen.violent_response =    "Not heard or seen a thing, well apart from that someone was murdered";
		George_allen.threaten_response =   "You don't scare me detective, I see through you";
		George_allen.kind_response =       "I'm not your friend, I've got nothing";
		George_allen.friendly_response =   "I heard they liked to drink a lot but thats it, not sure if thats useful or not?";
		George_allen.sympthetic_response = "I agree but im sorry i've got nothing, wish ic ould give you something";
        George_allen.cunning_response =    "You're clearly hearing things! Ive got nothing else to say to you dont bother asking";
        George_allen.mean_response =       "I think i look quite good thanks, And i haven't seen anything";

		//no more interaction setup
		George_allen.dont_interact_response = "thought I told you to go away";
        George_allen.dont_interact_if1 = George_allen.cunning_response;
        George_allen.dont_interact_if2 = George_allen.sympthetic_response;

        //clue response 
        George_allen.clue_response1 = "Violent";
        George_allen.clue_response2 = "Friendly";

        //incorrect accusation
        George_allen.incorect_accusation = "INCORRECT ACCUSATION";
		
	}



	public void make_Ethan()
	{
        //basic setup
		Ethan_hawk.Name = "Ethan";
		Ethan_hawk.intro = "I will have my own Ferrari someday!";
		ethan_look.sprite = Ethan_hawk.look;
		Ethan_hawk.he_she = "he";
        Ethan_hawk.initial = "E.H";
        Ethan_hawk.man_woman = "man";
        Ethan_hawk.age = 31;

		//responses
		Ethan_hawk.aggressive_response = "I was upstairs in the lecture hall";
		Ethan_hawk.violent_response = "Don't take that tone with me, don't you think if I knew something I would say?";
		Ethan_hawk.threaten_response = "Calm down this doesn't need to get out of control, I haven't a clue about whats happened";
		Ethan_hawk.kind_response = "Sorry 'friend' I've got nothing";
		Ethan_hawk.friendly_response = "Saw them around but thats about it, nothing out of the ordinary";
		Ethan_hawk.sympthetic_response = "thanks i appreiacte it but i cant say ive seen anything detective";
        Ethan_hawk.cunning_response = "I don't know whos telling you this but its not true";
        Ethan_hawk.mean_response = "Dont appreaicte you being mean to me, theres too much going on. Dont ask me anything else";

		//no more interaction setup
		Ethan_hawk.dont_interact_response = "I no longer wish to speak to you!";
        Ethan_hawk.dont_interact_if1 = Ethan_hawk.aggressive_response;  // DONT TALK IF AGGRESIVE
        Ethan_hawk.dont_interact_if2 = Ethan_hawk.mean_response;

        //clue response 
        Ethan_hawk.clue_response1 = "Violent";
        Ethan_hawk.clue_response2 = "Kind";

        //incorrection accusation 
        Ethan_hawk.incorect_accusation = "incorrect accusation";
		

    }



	public void make_Ryan()
	{
        //basic setup
		Ryan_Smith.Name = "Ryan";
		Ryan_Smith.intro = "I'm Ryan Smith, and I'm a lawyer";
		ryan_look.sprite = Ryan_Smith.look;
		Ryan_Smith.he_she = "he";
        Ryan_Smith.initial = "R.S";
        Ryan_Smith.man_woman = "man";
        Ryan_Smith.age = 45;
        
        //responses
		Ryan_Smith.aggressive_response = "I was in the kitchen, was just having a walk around";
		Ryan_Smith.violent_response = "*burts into tears* - a faint mumble can be heard";
		Ryan_Smith.threaten_response = "yeah sure, I know my rights. im going to report you detective!";
		Ryan_Smith.kind_response = "Only heard that the killer is here somewhere! please catch them before theres another";
		Ryan_Smith.friendly_response = "Not much to say, probably could hit the gym ";
		Ryan_Smith.sympthetic_response = "Cheers and nothing, wrong place wrong time I guess";
        Ryan_Smith.cunning_response = "If you believe that you can't be a good detective, so dont talk to me again.";
        Ryan_Smith.mean_response = "Look go away if youre going to be mean, I thouht you were here to help";

        //no more interaction
		Ryan_Smith.dont_interact_response = "I no longer wish to speak to you!";
        Ryan_Smith.dont_interact_if1 = Ryan_Smith.cunning_response;
        Ryan_Smith.dont_interact_if2 = Ryan_Smith.friendly_response;

        //clue response 
        Ryan_Smith.clue_response1 = "Kind";
        Ryan_Smith.clue_response2 = "Aggresive";

        // incorrect accusation 
        Ryan_Smith.incorect_accusation = "incorrect accuasation";		
	}

	public void make_Zoe()
	{
        //basic setup
		Zoe_Williams.Name = "Zoe";
		Zoe_Williams.intro = "Go to talk with my agent.";
		zoe_look.sprite = Zoe_Williams.look;
		Zoe_Williams.he_she = "she";
        Zoe_Williams.initial = "Z.W";
        Zoe_Williams.man_woman = "woman";
        Zoe_Williams.age = 26;

		//responses
		Zoe_Williams.aggressive_response = "Why does it matter to you? I know I'm not guilty ";
        Zoe_Williams.violent_response = "Look I haven't seen anything okay"; 
		Zoe_Williams.threaten_response = "nothing! I know nothing!";
		Zoe_Williams.kind_response = "I think youre doing a terrible job! stop talking to me in innocent and them the killer!";
		Zoe_Williams.friendly_response = "never seen them before, never spoke to them";
		Zoe_Williams.sympthetic_response = "Yeah I suppose, just happy it wasn't me";
        Zoe_Williams.cunning_response = "yeah sure, good effort to try and get me mad";
        Zoe_Williams.mean_response = "Youre not looking great. Ive not no information, go away and learn some manners";

		//no more interaction setup
		Zoe_Williams.dont_interact_response = "I no longer wish to speak to you!"; // need a way to make her be okay with not resposing if the player is kind 
        Zoe_Williams.dont_interact_if1 = Zoe_Williams.kind_response;
        Zoe_Williams.dont_interact_if2 = Zoe_Williams.sympthetic_response;

        //clue response
        Zoe_Williams.clue_response1 = "Mean";
        Zoe_Williams.clue_response2 = "Cunning";

        //incorrect accusation
        Zoe_Williams.incorect_accusation = "incorrect accusation";
		
	}
	public void make_Alice()
	{
        //basic setup
		Alice_Davis.Name = "Alice";
		Alice_Davis.intro = "I'm Zoe's agent, can I help you?";
		alice_look.sprite = Alice_Davis.look;
		Alice_Davis.he_she = "she";
        Alice_Davis.initial = "A.D";
        Alice_Davis.man_woman = "woman";
        Alice_Davis.age = 41;

        //responses
		Alice_Davis.aggressive_response = "I can't remember, I know that makes me sound bad";
		Alice_Davis.violent_response = "Iv'e only just heard theres been a murder, I've been working today";
		Alice_Davis.threaten_response = "No need to threaten me, I know your kind ";
		Alice_Davis.kind_response = "Sorry mate, heard nothing. If ou have anymore questions I'll be happy to help";
		Alice_Davis.friendly_response = "First time being here so I've never met them before";
        Alice_Davis.cunning_response = "What, No, I would never, Its not, please";
        Alice_Davis.mean_response = "You're a horrible person, Go away and dont bother coming back!";
		Alice_Davis.sympthetic_response = "Me to, Its a reminder there are some horrible people out there";

		//no more interaction setup
		Alice_Davis.dont_interact_response = "I no longer wish to speak to you!";
        Alice_Davis.dont_interact_if1 = Alice_Davis.mean_response;
        Alice_Davis.dont_interact_if2 = Alice_Davis.violent_response;

        //clue response
        Alice_Davis.clue_response1 = "Threaten";
        Alice_Davis.clue_response2 = "Sympthetic";

        //incorrect accusation
        Alice_Davis.incorect_accusation = "incorrect accusation";
		
	}

	public void make_Sophie()
	{
        //basic setup
		Sophie_Aaron.Name = "Sophie";
		Sophie_Aaron.intro = "I'm working in the hub as a waitress.";
		sophie_look.sprite = Sophie_Aaron.look;
		Sophie_Aaron.he_she = "she";
        Sophie_Aaron.initial = "S.A";
        Sophie_Aaron.man_woman = "woman";
        Sophie_Aaron.age = 32;

		//responses
		Sophie_Aaron.aggressive_response = "I think i was by the fire in the main hall, but I cant be sure";
		Sophie_Aaron.violent_response = "Don't speak to me like that, I dont have to talk to you, you know";
		Sophie_Aaron.threaten_response = "Walk away detective and we'll imagine you never said that to me";
		Sophie_Aaron.kind_response = "I see your game, trying to be nice to get info. Might might work for some but not me";
		Sophie_Aaron.friendly_response = "Not much, heard they gamble quite a lot ";
		Sophie_Aaron.sympthetic_response = "Im scared, plese find who did this, please" ;
        Sophie_Aaron.cunning_response = "I Don't belive you give me to proof";
        Sophie_Aaron.mean_response = "Alright well i dont know anything";

        //no more interaction setup
        Sophie_Aaron.dont_interact_response = "I no longer wish to speak to you!";
        Sophie_Aaron.dont_interact_if1 = Sophie_Aaron.threaten_response;
        Sophie_Aaron.dont_interact_if2 = Sophie_Aaron.aggressive_response; ;

        //clue response
        Sophie_Aaron.clue_response1 = "Violent";
        Sophie_Aaron.clue_response2 = "Sympthetic";

        //incorrect accusation
        Sophie_Aaron.incorect_accusation = "incorrect accuasation";
		
	}

	public void make_Stephen()
	{
        //basic information
		Stephen_Brown.Name = "Stephen";
		Stephen_Brown.intro = "Hi, Im stephen the best thing to happen to this world! ";
		stephen_look.sprite = Stephen_Brown.look;
		Stephen_Brown.he_she = "he";
        Stephen_Brown.initial = "S.B";
        Stephen_Brown.man_woman = "man";
        Stephen_Brown.age = 61;

		//responses
		Stephen_Brown.aggressive_response = "Under the balcony outside having a smoke";
		Stephen_Brown.violent_response = "nothing, Nothing I swear!";
		Stephen_Brown.threaten_response = "I've got no idea what happened, just leave me alone please";
		Stephen_Brown.kind_response = "Don't you think I would have said ealier if I knew anything, Dont bother talking to me again";
		Stephen_Brown.friendly_response = "Always use to hang around by the lakes smoking";
		Stephen_Brown.sympthetic_response = "I'm still shocked, I'm not thinking straight ";
        Stephen_Brown.cunning_response = "You're lying, I dont appreciate that go away";
        Stephen_Brown.mean_response = "i dont like your attitude, no ive got nothing to say";

		//no more interaction setup
		Stephen_Brown.dont_interact_response = "I no longer wish to speak to you!";
        Stephen_Brown.dont_interact_if1 = Stephen_Brown.kind_response;
        Stephen_Brown.dont_interact_if2 = Stephen_Brown.cunning_response;

        //clues response
        Stephen_Brown.clue_response1 = "Friendly";
        Stephen_Brown.clue_response2 = "Aggressive";

        //incorrect accusation
        Stephen_Brown.incorect_accusation = "incorrect accusation";

    }

	public void make_Robert()
	{
        //basic setup
		Robert_Henry.Name = "Robert";
		Robert_Henry.intro = "Hello Detective, i think i'm going to be alone forever ";
		robert_look.sprite = Robert_Henry.look;
		Robert_Henry.he_she = "he";
        Robert_Henry.initial = "R.H";
        Robert_Henry.man_woman = "man";
        Robert_Henry.age = 23;

		//responses
		Robert_Henry.aggressive_response = "I was in the meeting room upstairs, all alone...probably forever";
		Robert_Henry.violent_response = "I don't know anything, no tells me anything...so alone, please dont talk to me again";
		Robert_Henry.threaten_response ="Do it no one will care, so alone";
		Robert_Henry.kind_response = "did you say friend? Will you be my friend?! please, I've never had a friend";
        Robert_Henry.friendly_response = "Not much wasn't my friend, I dont have any friends you see";
		Robert_Henry.sympthetic_response = "I Will never forget this, thanks for all your help but i've got nothing to give";
        Robert_Henry.cunning_response = "No one would say that, no one knows me I have no friends";
        Robert_Henry.mean_response = "I agree, its probably why I have no friends, please dont talk to me again";

        //no more interaction setup
        Robert_Henry.dont_interact_response = "I said I don't want to talk anymore";
        Robert_Henry.dont_interact_if2 = Robert_Henry.friendly_response;
        Robert_Henry.dont_interact_if2 = Robert_Henry.threaten_response;

        //clues response 
        Robert_Henry.clue_response1 = "violent";
        Robert_Henry.clue_response2 = "Mean";

        //incorrect accusation
        Robert_Henry.incorect_accusation = "incorrect accusation"; 
	}


	
    



    public void makelst()   //create a list of the npc's
    {
        npc_list_[0] = Tonald_Dump;
        npc_list_[1] = Bernard_lowe;
        npc_list_[2] = George_allen;
        npc_list_[3] = Ethan_hawk;
		npc_list_[4] = Ryan_Smith;
		npc_list_[5] = Zoe_Williams;
        npc_list_[6] = Alice_Davis;
		npc_list_[7] = Sophie_Aaron;
		npc_list_[8] = Stephen_Brown;
        npc_list_[9] = Robert_Henry;
    }


    public void makegameobjectlst()   // make the gameobjet list 
    {
        gameobjectlst_[0] = Tonald;
        gameobjectlst_[1] = Bernard;
        gameobjectlst_[2] = George;
        gameobjectlst_[3] = Ethan;
        gameobjectlst_[4] = Ryan;
        gameobjectlst_[5] = Zoe;
        gameobjectlst_[6] = Alice;
        gameobjectlst_[7] = Sophie;
        gameobjectlst_[8] = Stephen;
        gameobjectlst_[9] = Robert;
    }






    public void set_murderer_and_victim_crime()  //sets a NPC to be ther murder and a differnt npc to be the victim 
    {
        
        crime.GetComponent<CreateCrime>().select_crime();   // make the crime selection 

       // Debug.Log(crime.GetComponent<CreateCrime>().murder_int); // DEBUGGING PURPOSES

        if (crime.GetComponent<CreateCrime>().murder_int == 1)  // drowned 
        {
            gameobjectlstshuffle_[6].GetComponent<NPC>().is_Victim();
            gameobjectlstshuffle_[6].GetComponent<SpriteRenderer>().sprite = dead;
            Gameman.GetComponent<gameManager>().set_victim(gameobjectlstshuffle_[6].GetComponent<NPC>());  // store data 
        }
        else if (crime.GetComponent<CreateCrime>().murder_int == 2) // pushed off lakehouse
        {
            gameobjectlstshuffle_[9].GetComponent<NPC>().is_Victim();
            gameobjectlstshuffle_[9].GetComponent<SpriteRenderer>().sprite = dead;
            Gameman.GetComponent<gameManager>().set_victim(gameobjectlstshuffle_[9].GetComponent<NPC>());  // store data 

        } else
        {
            int x = Random.Range(0, 10);       // random number between 0 and 9
            npc_list_[x].is_Victim();
            GameObject.FindWithTag(npc_list_[x].Name).GetComponent<SpriteRenderer>().sprite = dead;
            Gameman.GetComponent<gameManager>().set_victim(npc_list_[x]);  // store data 
        }

        lst_no_victim();                   // create list of all other npcs who arent the victim 

        int y = Random.Range(0, 9);       // random number between 0 and 9
        npc_list_vic_[y].isMurder();           // get npc at x in the array and set to muderer
        Gameman.GetComponent<gameManager>().set_murder(npc_list_vic_[y]);    // store data in game manager 
        
    }

    public void lst_no_victim()   // creates a list of all other npcs who are not the victim. --> called in fucntion set_murder_and_victim()
    {
        int y = 0;
        for (int x =0; x < npc_list_.Length; x++)
        {
            if (npc_list_[x].is_victim == false)
            { 
                npc_list_vic_[y] = npc_list_[x];
                y++;
            } else
                ;
        }
    }

    public void list_no_vic_murder()
    {
        int x = 0;
        for (int y = 0; y < npc_list_vic_.Length; y++)
        {
            if (npc_list_vic_[y].is_muderer == false)
            {
                npc_list_mur_vic[x] = npc_list_vic_[y];
                x++;
            } else
            {
                ;
            }
        }

    }



   



    public void shuffle_lst()    // prodcues a shuffled list of all the npcs; --> used in the setroom() as it ensures they will be placed randomly into a room each time the game is loaded.  
    {
        for(int x =0; x<gameobjectlst_.Length;x++)     
        {
            int y = Random.Range(0, 10);
            while (gameobjectlstshuffle_[y] != null)    // while the element in the array gameobjectlstshuffle is empty put a random element y into it from gameobjectlst
            {                                           // otherwise keep randomising the element for y untill a space is found. 
                y = Random.Range(0, 10);
            }
            gameobjectlstshuffle_[y] = gameobjectlst_[x];

        }
    }



   

    public void setroom()
    {
        Gameman.GetComponent<gameManager>().setroom11(gameobjectlstshuffle_[0]);   //set the npc in room 1 pos 1 to shuffled index 0. 
        gameobjectlstshuffle_[0].GetComponent<NPC>().room = "RCH1";
        Gameman.GetComponent<gameManager>().setroom12(gameobjectlstshuffle_[1]);
        gameobjectlstshuffle_[1].GetComponent<NPC>().room = "RCH1";
        Gameman.GetComponent<gameManager>().setroom21(gameobjectlstshuffle_[2]);
        gameobjectlstshuffle_[2].GetComponent<NPC>().room = "RCH2";
        Gameman.GetComponent<gameManager>().setroom31(gameobjectlstshuffle_[3]);
        gameobjectlstshuffle_[3].GetComponent<NPC>().room = "Meeting Room";
        Gameman.GetComponent<gameManager>().setroom41(gameobjectlstshuffle_[4]);
        gameobjectlstshuffle_[4].GetComponent<NPC>().room = "Kitchen";
        Gameman.GetComponent<gameManager>().setroom51(gameobjectlstshuffle_[5]);
        gameobjectlstshuffle_[5].GetComponent<NPC>().room = "Balcony";
        Gameman.GetComponent<gameManager>().setroom61(gameobjectlstshuffle_[6]);
        gameobjectlstshuffle_[6].GetComponent<NPC>().room = "Lakes";
        Gameman.GetComponent<gameManager>().setroom71(gameobjectlstshuffle_[7]);
        gameobjectlstshuffle_[7].GetComponent<NPC>().room = "upstairs lecture hall";
        Gameman.GetComponent<gameManager>().setroom72(gameobjectlstshuffle_[8]);       
        gameobjectlstshuffle_[8].GetComponent<NPC>().room = "upstairs lecture hall";
        Gameman.GetComponent<gameManager>().setroom81(gameobjectlstshuffle_[9]);
        gameobjectlstshuffle_[9].GetComponent<NPC>().room = "belowe the baclony";
        
    }   



    public void Make_NPC() // called when initilased so to create all of the NPC's 
    {

        // STAGE 1 
         
        setNCPS();         // set the gameobjects to the corect npc

        make_tonald();     // make all of the npcs and sets them to the objects. 
        make_bernard();
        make_Ethan();
        make_George();
        make_Ryan();
        make_Zoe();
        make_Alice();
        make_Sophie();
        make_Stephen();
        make_Robert();

        makelst();                  // make the lists 
        makegameobjectlst();
           

        shuffle_lst();                  //creates a shuffled list 

        setroom();                      // sets the npcs to a room

        // STAGE 2 

        set_murderer_and_victim_crime();      // pick the crime that will take place and vicim according, also select murderer 

        crime.GetComponent<CreateCrime>().create_crime();  // create the crime with all of the paramater sets in the previous function 
        list_no_vic_murder();                              // create a list of only NPC's who are not the murderer or the victim
        clues.GetComponent<createClue>().makeClues();      // make the clues for the game.... 
        
    }

   




    // Use this for initialization
    void Start() {
        Make_NPC();

        // debugging 
        Debug.Log("the murderer is: " + Gameman.GetComponent<gameManager>().get_murder());
        Debug.Log("the victim is: " + Gameman.GetComponent<gameManager>().get_victim());
        
    }


	
	// Update is called once per frame
	void Update () {
	
	}
}
