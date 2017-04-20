using UnityEngine;
using System.Collections;
using System.Linq;  // to be able to use contains in array checking 

public class createClue: MonoBehaviour{

    /*
     * createClue is called by createNPC and after createCrime. Once the crime has been created the relevant clues will be selected to fit the murder 
     */

	public GameObject game_manager;
    public GameObject crime;
    public GameObject createnpc;
    public GameObject cluesprites;

    // the game objects which hold the clues 
	public GameObject clue1;
	public GameObject clue2;
	public GameObject clue3;
	public GameObject clue4;
	public GameObject clue5;
	public GameObject clue6;
	public GameObject clue7_verbal;
	public GameObject clue8_verbal;
	public GameObject motiveClueObj;	//__NEW__ADDITION__

    // the attributes for the clue which are attached to the game objects 
	public clue clue_1;
	public clue clue_2;
	public clue clue_3;
	public clue clue_4;
	public clue clue_5;
	public clue clue_6;
	public clue verbal_clue_7;
	public clue verbal_clue_8;
	public clue motiveClue; //__NEW__ADDITION__


    // Arrays to make accessing the clue easier 
    public GameObject[] gameobjectlst_ = new GameObject[6];  // Array of all of the GameObject -- the item clues
    public GameObject[] gameobjectlstverbal_ = new GameObject[3]; 

    // initialise all of the game objects to have clue attributes 
	public void setClues()
    {
        // get the components for each of the clues 
		clue_1 = clue1.GetComponent<clue>();
        clue_1.cluename = "Clue1";
        clue1.GetComponent<SpriteRenderer>().sprite = clue_1.look ;

		clue_2 = clue2.GetComponent<clue>();
        clue_2.cluename = "Clue2";
        clue2.GetComponent<SpriteRenderer>().sprite = clue_2.look;

        clue_3 = clue3.GetComponent<clue>();
        clue_3.cluename = "Clue3";
        clue3.GetComponent<SpriteRenderer>().sprite = clue_3.look ;

        clue_4 = clue4.GetComponent<clue>();
        clue_4.cluename = "Clue4";
        clue4.GetComponent<SpriteRenderer>().sprite = clue_4.look ;

        clue_5 = clue5.GetComponent<clue>();
        clue_5.cluename = "Clue5";
        clue5.GetComponent<SpriteRenderer>().sprite = clue_5.look ;

        clue_6 = clue6.GetComponent<clue>();
        clue_6.cluename = "Clue6";
        clue6.GetComponent<SpriteRenderer>().sprite = clue_6.look  ;

        verbal_clue_7 = clue7_verbal.GetComponent<clue>();
        verbal_clue_7.is_verbal = true;
        
        verbal_clue_8 = clue8_verbal.GetComponent<clue>();
        verbal_clue_8.is_verbal = true;

		//___NEW___ADDITON___
		motiveClue = motiveClueObj.GetComponent<clue> ();
		motiveClue.is_verbal = true;
    }

// ---------------------------------------------------------------------------------------------------------

    // make all of the clues if the murder is STAB IN BACK CRIME 

    public void make_clues_crime_1()   // COMPLETE 
    {
        string[] weapons = new string[3]{ "Flick Knife", "Meat Clever", "Sharpened Metal Ruler" };
        int x = Random.Range(0, 3);   // pick a random murder weapon
        clue_1.name = weapons[x];
        clue_1.info = "the blade looks smudged, maybe something was wiped off?";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_1.name); 
		clue_1.look = addsprites1 (clue_1.name);


        string[] throw_off_weapon = new string[3] { "swiss army knife", "dagger", "sword" };
        int y = Random.Range(0, 3);
        clue_2.name = throw_off_weapon[y];
        clue_2.info = "the blade looks clean....maybe too clean?";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_2.name);
        clue_2.look = addsprites1(clue_2.name);

        clue_3.name = "Hand written note to Victim";
        clue_3.info = ("A note addressed to " + game_manager.GetComponent<gameManager>().get_victim() + ". Saying 'Meet in " +
        game_manager.GetComponent<gameManager>().get_whole_victim().room + " with £5000 or else' \n It has been  handwritten in black ink");
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_3.name);
        clue_3.look = addsprites1(clue_3.name);

        clue_4.name = "cloth with blood on";
        clue_4.info = "Must have been used to wipe the murder weapon";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_4.name);
        clue_4.look = addsprites1(clue_4.name);

        string[] hat = new string[3] { "Top Hat", "flat cap", "beanie" };
        int z = Random.Range(0, 3);
        clue_5.name = hat[z];
        clue_5.info = "The hat has two sets of initials in it, "+ game_manager.GetComponent<gameManager>().get_whole_murderer().initial + " and " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].initial ;
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_5.name);
        clue_5.look = addsprites1(clue_5.name);

        clue_6.name = "Black foutain pen";
        clue_6.info = "A black fountain pen, looks expensive";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites1(clue_6.name);
        clue_6.look = addsprites1(clue_6.name);

        verbal_clue_7.name = ("saw someone hanging around " + game_manager.GetComponent<gameManager>().get_whole_victim().room + " wearing a " + hat[z]
            + ". " + game_manager.GetComponent<gameManager>().get_whole_murderer().he_she +  " looked a bit shifty.");

        verbal_clue_8.name = "I saw " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].Name + " playing with a " + throw_off_weapon[y] + " ealier";

		//___NEW__ADDITION__
		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " stole " + game_manager.GetComponent<gameManager>().get_murder() + "'s new car.";
		motiveClue.is_motive = true;
    }

    // --------------------------------------------------------------------------------------------------------


    public void make_clues_crime_2()   // CLUES FOR DROWNED COMPLETED 
    {
        int z = Random.Range(0, 8);

        clue_1.name = "Flick Knife";  // make a list of items 
        clue_1.info = "Strange to find that here,seems a bit out of place";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_1.name);
        clue_1.look = addsprites2(clue_1.name);

        clue_2.name = "Criket Bat";
        clue_2.info = "Victim didn't have any bruise marks so I doubt they were hit";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_2.name);
        clue_2.look = addsprites2(clue_2.name);

        clue_3.name = "A set of wet Ron Cooke HUB janitor gloves";
        clue_3.info = "The only people who are janitors here are " + game_manager.GetComponent<gameManager>().get_murder() + " and " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z];
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_3.name);
        clue_3.look = addsprites2(clue_3.name);

        clue_4.name = "A Note" ;
        clue_4.info = "Addressed to " + game_manager.GetComponent<gameManager>().get_victim() + " saying 'Meet at the lakes at 7', I Wonder who she was meeting? ";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_4.name);
        clue_4.look = addsprites2(clue_4.name);

        clue_5.name = "A Present";
        clue_5.info = "Tag says 'To " + game_manager.GetComponent<gameManager>().get_victim() + " Happy Birthday! x' " +"Drowned on " + game_manager.GetComponent<gameManager>().get_whole_victim().he_she + " birhday, how horrible";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_5.name);
        clue_5.look = addsprites2(clue_5.name);

        clue_6.name = "A pair of shoes with damp mud over the front";
        clue_6.info = "The shoes are a " + game_manager.GetComponent<gameManager>().get_whole_murderer().man_woman + "'s size 4. The only mud around is outside by the lakes ";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites2(clue_6.name);
        clue_6.look = addsprites2(clue_6.name);

        verbal_clue_7.name = ("I saw " + game_manager.GetComponent<gameManager>().get_murder() + " and " + game_manager.GetComponent<gameManager>().get_victim() + " shouting at each other earlier, sounded serious" );

        verbal_clue_8.name = "Normally " + game_manager.GetComponent<gameManager>().get_murder() + " and " + createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[z].Name + " hang around outside by the lake";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_murder() + " is a professional assassin, who was contracted to kill " + game_manager.GetComponent<gameManager>().get_victim() + ".";
		motiveClue.is_motive = true;
    }

    // --------------------------------------------------------------------------------------------------------

    public void make_clues_crime_4()  // STRANGLLED WITH SCARF COMPLETED 
    {
        clue_1.name = "Streched Red Scarf";
        clue_1.info = "Looks like an ordinary scaft, it has been Visibly streched. Pulled from both ends tightly it seems";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_1.name);
        clue_1.look = addsprites4(clue_1.name);

        clue_2.name = "A note to the victim";
        clue_2.info = "Victim was invited to a Ball tonight. letter is signed from " + random_murder_or_NPC_name();
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_2.name);
        clue_2.look = addsprites4(clue_2.name);

        string[] jewlery = {"Pendant","Ring" };
        int z = Random.Range(0, 1);
        clue_3.name = jewlery[z];
        clue_3.info = "Scribed into the ring is the initals " + game_manager.GetComponent<gameManager>().get_whole_victim().initial + "inside. guess the killer didn't do it for the jewlery";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_3.name);
        clue_3.look = addsprites4(clue_3.name);

        string[] weapons = { "meat clever", "dagger" };
        int x = Random.Range(0, 1);
        clue_4.name = weapons[x];
        clue_4.info = "Its covered in blood, however the victim doesn't seem to have any cuts on them? maybe it was misplaced? ";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_4.name);
        clue_4.look = addsprites4(clue_4.name);

        clue_5.name = "coin sack";
        clue_5.info = "A large coin sack with the name " + random_murder_or_NPC_name() + "sown into it, no would would leave this behind without being in a rush";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_5.name);
        clue_5.look = addsprites4(clue_5.name);

        string[] hats = { "top hat", "beanie" };
        clue_6.name = hats[z];
        clue_6.info = "Guess someone didn't want their hat";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites4(clue_6.name);
        clue_6.look = addsprites4(clue_6.name);

        int y = Random.Range(0, 8);
        string[] order_murder = { game_manager.GetComponent<gameManager>().get_murder() + ", " + getNPC(y).Name, getNPC(y).Name + ", " + game_manager.GetComponent<gameManager>().get_murder() };
        int a = Random.Range(0, 1);
        verbal_clue_7.name = "I saw " +order_murder[a]+" and "+ game_manager.GetComponent<gameManager>().get_victim() +"walk into " + game_manager.GetComponent<gameManager>().get_whole_victim().room;

        verbal_clue_8.name = random_murder_or_NPC_name() + " was wearing a scarf earlier, but haven't seen it for a while";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " knew " + game_manager.GetComponent<gameManager>().get_murder() + "'s darkest secret.";
		motiveClue.is_motive = true;
    }

    // --------------------------------------------------------------------------------------------------------

    public void make_clues_crime_3()  // PUSHED OVER THE LAKEHOUSE BALCONY COMPLETED
    {
        clue_1.name = "Handkerchief";
        clue_1.info = "Has the initials " + random_murder_or_NPC_name() + "emborded in red silk and blood in the corner" ;
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_1.name);
        clue_1.look = addsprites3(clue_1.name);

        clue_2.name = "Jacket";
        clue_2.info = "Initals inside of the jacket are " + game_manager.GetComponent<gameManager>().get_whole_murderer().initial + "the jacket has been torn on the front - bit odd";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_2.name);
        clue_2.look = addsprites3(clue_2.name);

        
        clue_3.name = "coin sack";
        clue_3.info = "Coin sack was left on the floor, must have been dropped In a hurry";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_3.name);
        clue_3.look = addsprites3(clue_3.name);

        string[] wacthes = { "wacth", "pocket watch" };
        int x = Random.Range(0, 1);
        clue_4.name = wacthes[x] ;
        clue_4.info = "On the back slightly scrathed it bares the initals " + game_manager.GetComponent<gameManager>().get_whole_victim().initial + "must have been the victims" ;
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_4.name);
        clue_4.look = addsprites3(clue_4.name);

        clue_5.name = "torn cloth";
        clue_5.info = "Peice of fabric matches the victims clothing - must have been a struggle";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_5.name);
        clue_5.look = addsprites3(clue_5.name);

        int y = Random.Range(0, 8);
        string[] order = { game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " and " + getNPC(y).Name, getNPC(y).Name + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name };
        clue_6.name = "Clipboard";
        clue_6.info = "Has bookings for the balcony at time of murder, Looks like its booked under " + order[x];
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites3(clue_6.name);
        clue_6.look = addsprites3(clue_6.name);

        
        verbal_clue_7.name = "After I heard the screem, I ran upsatirs and ran past " + random_murder_or_NPC_name() + " coming down";

        verbal_clue_8.name = "Well, " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " has been asking everyone if they ave seen his coin sack if that of any relevance ";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " convinced " + game_manager.GetComponent<gameManager>().get_murder() + " to take a gamble which didn't pay off.";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_5()  // POSIONED COMPLETED 
    {
        clue_1.name = "A note";
        clue_1.info = "The note is adressed to the victim and was given along with a bottle of wine it seems. Note signed from " + random_murder_or_NPC_name();
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_1.name);
        clue_1.look = addsprites5(clue_1.name);

        clue_2.name = "Empty bottle";
        clue_2.info = "Empty bottle of wine, nothing smells odd about the bottle however?";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_2.name);
        clue_2.look = addsprites5(clue_2.name);


        clue_3.name = "Flask";
        clue_3.info = "A small empty flask. The flask doesnt smell of anything unusual adn the cap is missing?";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_3.name);
        clue_3.look = addsprites5(clue_3.name);

        
        clue_4.name = "Black fountain pen";
        clue_4.info = "A black fountain pen, good quialty - finders keepers";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_4.name);
        clue_4.look = addsprites5(clue_4.name);

        string[] weapon = { "dagger", "sword" };
        int x = Random.Range(0, 1);
        int y = Random.Range(0, 8);
        clue_5.name = weapon[x];
        clue_5.info = "Bares the initials " + getNPC(y).initial + " on the blade, must be used for decoration";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_5.name);
        clue_5.look = addsprites5(clue_5.name);

        clue_6.name = "Flask lid";
        clue_6.info = "Flask lid has been scratched and only the first inital " + game_manager.GetComponent<gameManager>().get_whole_murderer().initial[0] + " can be seen";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites5(clue_6.name);
        clue_6.look = addsprites5(clue_6.name);

        string[] order = { game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " and " + getNPC(y).Name, getNPC(y).Name + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name };
        verbal_clue_7.name = "First time I've seen " + order[x] + "using flasks, maybe they are big drinkers" ;

		verbal_clue_8.name = "apparently " + game_manager.GetComponent<gameManager>().get_murder() + "stole a bottle of wine.";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_murder() + "'s husband had an affair with " + game_manager.GetComponent<gameManager>().get_victim() + ".";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_6()  // SHOT WITH ARROW
    {
        clue_1.name = "Arrow";
        clue_1.info = "This must be the murder weapon, blood all over the head, stupid to try and hide it ";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_1.name);
        clue_1.look = addsprites6(clue_1.name);

        string[] objs = {"coin sack", "dagger"};
        int x = Random.Range(0, 1);
        clue_2.name = objs[x];
        clue_2.info = "Has intials the initials " + game_manager.GetComponent<gameManager>().get_whole_victim().initial + "on it";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_2.name);
        clue_2.look = addsprites6(clue_2.name);

        clue_3.name = "Note";
        clue_3.info = "The note is adressed to the victim saying to go to " + game_manager.GetComponent<gameManager>().get_whole_victim().room + " and look out of the window - sounds like a setup";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_3.name);
        clue_3.look = addsprites6(clue_3.name);

        int y = Random.Range(0, 8);
        int z = Random.Range(0, 8);
        int a = Random.Range(0, 1);
        string[] initials = { game_manager.GetComponent<gameManager>().get_whole_murderer().initial + " and " + getNPC(z).initial, getNPC(z).initial + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().initial };
        clue_4.name = "Bow";
        clue_4.info = "odd bow, has the name " + getNPC(y).name + "and two sets of initials: " + initials[a] + " inside of it";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_4.name);
        clue_4.look = addsprites6(clue_4.name);

        clue_5.name = "Note";
        clue_5.info = "The Note is Adressed to " + getNPC(y).name + " and suggests they were having an affair, maybe the wrong person found out";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_5.name);
        clue_5.look = addsprites6(clue_5.name);

        clue_6.name = "Beanie";
        clue_6.info = "might wear a hat when shooting - dont want long hair getting in the way";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites6(clue_6.name);
        clue_6.look = addsprites6(clue_6.name);


        verbal_clue_7.name = "Only two people can shoot an arrow straight around here " + game_manager.GetComponent<gameManager>().get_whole_murderer().name + " and " + getNPC(y).Name ;

        verbal_clue_8.name = "I saw " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name + "sweating today, but it was freezing, maybehe was nervous?";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_murder() + "believed that " + game_manager.GetComponent<gameManager>().get_victim() + " was responsible for the death of a friend.";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_7()  // THROAT CUT 
    {
        string[] weapon = { "Meat clever", "Sword", "Dagger", "Sharp ruler" };
        clue_1.name = weapon[Random.Range(0,4)];
        clue_1.info = "Sharp enough to perform the murder but rusted in some parts";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_1.name);
        clue_1.look = addsprites7(clue_1.name);

        clue_2.name = "Cloth";
        clue_2.info = "The cloth has blood all over it, must have been used to wipe up blood";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_2.name);
        clue_2.look = addsprites7(clue_2.name);


        clue_3.name = "Broken glass shards";
        clue_3.info = "No broken windows so maybe from a wine glass? A big shard looks missing";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_3.name);
        clue_3.look = addsprites7(clue_3.name);


        clue_4.name = "Big shard of glass";
        clue_4.info = "Its smugged along one edge and was hidden under a chair - why where they hidding it?";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_4.name);
        clue_4.look = addsprites7(clue_4.name);

        clue_5.name = "Note";
        clue_5.info = "Has a picture of " + game_manager.GetComponent<gameManager>().get_whole_victim().Name + " and with a red circle around and £200 beneath - Maybe it was a hit?";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_5.name);
        clue_5.look = addsprites7(clue_5.name);

        clue_6.name = "Pocket watch";
        clue_6.info = "Has the initials " + game_manager.GetComponent<gameManager>().get_whole_victim().initial + " on the back, must have been the victims ";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites7(clue_6.name);
        clue_6.look = addsprites7(clue_6.name);

        int x = Random.Range(0, 8);
        string[] order = {"I saw " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " and " + getNPC(x).Name + " exchange a large money sack earlier outside", "I saw " + getNPC(x).Name + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name + "exchange a large money sack earlier outside" };
        verbal_clue_7.name = order[Random.Range(0, 1)];

        verbal_clue_8.name = "Heard a glass smash earlier and not long after screams as the body was found";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " was in competition with " + game_manager.GetComponent<gameManager>().get_murder() + " professionally.";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_8() // crushed by chandelier
    {
        clue_1.name = "frayed rope";
        clue_1.info = "A frayed peice of rope, It use to hold the chandelier in place, someone cut through cut - explains how it fell";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_1.name);
        clue_1.look = addsprites8(clue_1.name);

        string[] weapon = { "metal ruler", "dagger" };
        clue_2.name = weapon[Random.Range(0, 1)];
        clue_2.info = "Both sharp tools, can be used for cutting";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_2.name);
        clue_2.look = addsprites8(clue_2.name);


        clue_3.name = "footprint";
        clue_3.info = "A dusty Foot print must be a " + game_manager.GetComponent<gameManager>().get_whole_murderer().man_woman + "'s size 4 - lot of dust upstairs in the attic";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_3.name);
        clue_3.look = addsprites8(clue_3.name);


        clue_4.name = "Note";
        clue_4.info = "Its a plan for the Ron Cooke hub - showing the attic is where all lights are fixed through";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_4.name);
        clue_4.look = addsprites8(clue_4.name);

        clue_5.name = "broken glass";
        clue_5.info = "Must be some glass from the chandelier when it smashed";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_5.name);
        clue_5.look = addsprites8(clue_5.name);

        clue_6.name = "Set of keys";
        clue_6.info = "keys for all rooms in the Ron cooke hub except for the attic";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites8(clue_6.name);
        clue_6.look = addsprites8(clue_6.name);

        verbal_clue_7.name = game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " asked to borrow my keys ealier but returned them quickly. unsual for anyone to ask for my keys";

        int x = Random.Range(0, 8);
        string[] order = { game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " and " + getNPC(x), getNPC(x) + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().Name };
        verbal_clue_8.name = "We were all there when it fell, the only two not around where " + order[Random.Range(0,2)];

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " was attempting to blackmail " + game_manager.GetComponent<gameManager>().get_murder() + ".";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_9()
    {
        clue_1.name = "Burnt scrap of clothing";
        clue_1.info = "must have come off od the victims clothing";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_1.name);
        clue_1.look = addsprites9(clue_1.name);

        string[] weapon = { "Dagger", "meat clever", "pen" };
        clue_2.name = weapon[Random.Range(0,2)];
        clue_2.info = "Weapon is sharp and smudged, could it be the murder weapon";
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_2.name);
        clue_2.look = addsprites9(clue_2.name);

        clue_3.name = "Shirt";
        clue_3.info = "white shirt covered in blood. Its a " + game_manager.GetComponent<gameManager>().get_whole_murderer().man_woman + "'s shirt";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_3.name);
        clue_3.look = addsprites9(clue_3.name);

        string[] weapons2 = { "sword", "metal ruler" };
        clue_4.name = weapons2[Random.Range(0,1)];
        clue_4.info = "Weapon has the name " + random_murder_or_NPC_name() + "scribbed onto the side. Blade looks clean however";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_4.name);
        clue_4.look = addsprites9(clue_4.name);

        clue_5.name = "Note" ;
        clue_5.info = "Found in a envelope, its a letter from the victim to here mum saying she was worried about her safety here, she must have known who did this";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_5.name);
        clue_5.look = addsprites9(clue_5.name);

        clue_6.name = "gloves";
        clue_6.info = "A pair of gloves with the name " + random_murder_or_NPC_name() + " insde";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites9(clue_6.name);
        clue_6.look = addsprites9(clue_6.name);

        verbal_clue_7.name = "I've heard " + game_manager.GetComponent<gameManager>().get_whole_victim().Name + " and " + getNPC(Random.Range(0,7)).Name + "shouting at each other a lot lately";

        verbal_clue_8.name = (game_manager.GetComponent<gameManager>().get_whole_victim().Name + "told me that " + game_manager.GetComponent<gameManager>().get_whole_murderer().he_she + " has been worried about " 
            + game_manager.GetComponent<gameManager>().get_whole_murderer().Name + " recently but didn't say why");

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " was looking after " + game_manager.GetComponent<gameManager>().get_murder() + "'s dog when it died of electrocution.";
		motiveClue.is_motive = true;
    }

    // -------------------------------------------------------------------------------------------------------

    public void make_clues_crime_10()
    {
        clue_1.name = "Statue";
        clue_1.info = "A small statue of an idol - some sort of ritual maybe?";
        clue1.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_1.name);
        clue_1.look = addsprites10(clue_1.name);

        int x = Random.Range(0, 7);
        string[] initals = { game_manager.GetComponent<gameManager>().get_whole_murderer().initial + " and " + getNPC(x).initial, getNPC(x).initial + " and " + game_manager.GetComponent<gameManager>().get_whole_murderer().initial };
        clue_2.name = "Book";
        clue_2.info = "A small book with burns and covered in blood. Inside of the cover are the initals " + initals[Random.Range(0,2)];
        clue2.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_2.name);
        clue_2.look = addsprites10(clue_2.name);

        string[] weapon = { "Dagger", "Sword" };
        clue_3.name = weapon[Random.Range(0,2)];
        clue_3.info = "Also covered in blood with the initials " +  random_murder_or_NPC_name() + " on the bottom of the blade";
        clue3.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_3.name);
        clue_3.look = addsprites10(clue_3.name);


        clue_4.name = "Heart";
        clue_4.info = "It must be the victims heart and has a bite taken out of it - Strange";
        clue4.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_4.name);
        clue_4.look = addsprites10(clue_4.name);

        clue_5.name = "Sandles";
        clue_5.info = "A pair of " + game_manager.GetComponent<gameManager>().get_whole_murderer().man_woman + "'s sandles. The underneath has drops of blood over";
        clue5.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_5.name);
        clue_5.look = addsprites10(clue_5.name);

        clue_6.name = "Coin Sack";
        clue_6.info = "coin sack is full - no one would leave this behind unless they were in a rush";
        clue6.GetComponent<SpriteRenderer>().sprite = addsprites10(clue_6.name);
        clue_6.look = addsprites10(clue_6.name);

        verbal_clue_7.name = "I saw " + game_manager.GetComponent<gameManager>().get_whole_murderer().name + " run out of hte on cooke hub cluthing at a tattered book. looked like there was blood on it";

        verbal_clue_8.name = game_manager.GetComponent<gameManager>().get_whole_murderer().name +" has been looking for his coin sack for a while ";

		motiveClue.name = game_manager.GetComponent<gameManager>().get_victim() + " unfriended " + game_manager.GetComponent<gameManager>().get_murder() + " on Facebook.";
		motiveClue.is_motive = true;
    }

    // ---------------------------------------------------------------------------------------------

    private string random_murder_or_NPC_name()  // returns a random name of NPC or of the Murder - used to help create the clues for the crime
    {
        int z = Random.Range(0, 1);
        if (z == 0)
        {
            return game_manager.GetComponent<gameManager>().get_murder();
        } else
        {
            int x = Random.Range(0, 8);
            return createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[x].Name;
        }
    }


    private Sprite addsprites1(string name) // function used to add the sprite to the repective clues
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder1(name);
    }
    private Sprite addsprites2(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder2(name);
    }
    private Sprite addsprites3(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder3(name);
    }
    private Sprite addsprites4(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder4(name);
    }
    private Sprite addsprites5(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder5(name);
    }
    private Sprite addsprites6(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder6(name);
    }
    private Sprite addsprites7(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder7(name);
    }
    private Sprite addsprites8(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder8(name);
    }
    private Sprite addsprites9(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder9(name); 
    }
    private Sprite addsprites10(string name)
    {
        return cluesprites.GetComponent<cluesprites>().getsprites_murder10(name);
    }



    // depending on the murder selcted in the create crime scirpt the approiate clue will be selected. 
    public void set_clues_crime()
    {
        if (crime.GetComponent<CreateCrime>().murder_int == 0)   // clues only set for if the murder is the STABBED IN THE BACK  rest need to be done still 
        {
            make_clues_crime_1();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 1) // set clues for DROWNED murder 
        {
            make_clues_crime_2();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 2) // set clues for pushed of balcony
        {
            make_clues_crime_3();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 3) // set clues for strangled
        {
            make_clues_crime_4();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 4) // set clues for the posioned
        { 
            make_clues_crime_5();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 5) // set clues for shot with arrow
        {
            make_clues_crime_6();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 6) //set clues for a throat slitting
        {
            make_clues_crime_7();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 7) //set clues for falling chandelier
        {
            make_clues_crime_8();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 8) //set clues for falling chandelier
        {
            make_clues_crime_9();
        }
        if (crime.GetComponent<CreateCrime>().murder_int == 9) //set clues for heart ritual
        {
            make_clues_crime_10();
        }

    }

	public void make_game_object_lst()  // creates list of the clues 
    {
		gameobjectlst_ [0] = clue1;
		gameobjectlst_ [1] = clue2;
		gameobjectlst_ [2] = clue3;
		gameobjectlst_ [3] = clue4;
		gameobjectlst_ [4] = clue5;
		gameobjectlst_ [5] = clue6;
	}


    public void make_gameobj_lst_verbal()  // craetes a list of the verbal clues 
    {
        gameobjectlstverbal_ [0] = clue7_verbal;
        gameobjectlstverbal_ [1] = clue8_verbal;
		gameobjectlstverbal_ [2] = motiveClueObj;  
    }

    public NPC getNPC(int x)  // helps to get a NPC ranadomly quickly for creating clues
    {
        return createnpc.GetComponent<CreateNPC>().npc_list_mur_vic[x];
        
    }
		
	public void setCluesInGameman(){

        int[] clue_room_pos_ = new int[7] {0,1,2,3,4,5,6};
        int[] random_room_pos = new int[6];


        for ( int a = 0; a<6; a++ )  // produces a random list of 6 differnt ints from 0 to 7 
        {
            int b = Random.Range(0, clue_room_pos_.Length);
            int c = clue_room_pos_[b];

            while (c == 10)    // just using a radnom number to fill in he space with once its been read so it wont be selected again 
            {
                b = Random.Range(0, clue_room_pos_.Length);
                c = clue_room_pos_[b];
            }
            random_room_pos[a] = clue_room_pos_[b];
            clue_room_pos_[b] = 10;

        }

        for (int c = 0; c < 6; c++)
        {
            int d = random_room_pos[c];

            if ( c == 5)
            {
                game_manager.GetComponent<gameManager>().setClue8(gameobjectlst_[c]);  // forces the clue to be put in the hiddenroom


            } else
            {
                if (d == 0)
                {
                    game_manager.GetComponent<gameManager>().setClue1(gameobjectlst_[c]);
                }
                else if (d == 1)
                {
                    game_manager.GetComponent<gameManager>().setClue2(gameobjectlst_[c]);
                }
                else if (d == 2)
                {
                    game_manager.GetComponent<gameManager>().setClue3(gameobjectlst_[c]);
                }
                else if (d == 3)
                {
                    game_manager.GetComponent<gameManager>().setClue4(gameobjectlst_[c]);
                }
                else if (d == 4)
                {
                    game_manager.GetComponent<gameManager>().setClue5(gameobjectlst_[c]);
                }
                else if (d == 5)
                {
                    game_manager.GetComponent<gameManager>().setClue6(gameobjectlst_[c]);
                }
                else if (d == 6)
                {
                    game_manager.GetComponent<gameManager>().setClue7(gameobjectlst_[c]);
                }
                

            }
            
            
        }
             

        // randomly assign NPC's the verbal clues 
        int x = Random.Range(0, 8);
        game_manager.GetComponent<gameManager>().setNPCclue(getNPC(x),gameobjectlstverbal_[0]); // give the 1st verbal clue to an NPC
        verbal_clue_7.npc_verbal = getNPC(x);

		int y = Random.Range (0, 8);
		while (y == x) {
			y = Random.Range (0, 8); 
		}
		game_manager.GetComponent<gameManager>().setNPCclue(getNPC(y), gameobjectlstverbal_[1]);
		verbal_clue_8.npc_verbal = getNPC(y);

		int z = Random.Range (0, 8);
		while ((z == x) || (z == y)) {
			z = Random.Range (0, 8); 
		}
		game_manager.GetComponent<gameManager> ().setNPCclue (getNPC (z), gameobjectlstverbal_ [2]);
		motiveClue.npc_verbal = getNPC (z);

    }



	public void makeClues()  // called to create all of the clues
    {  

        setClues();   // intialise all parts to clues to be empty

		make_game_object_lst();
        make_gameobj_lst_verbal(); // make list of verbal clues 

        set_clues_crime();    // depending on crime choosen at random make approiate clues to fit and set clues to have appropriate sprites 

		setCluesInGameman();  // randomly assign the clues to rooms 
	}



}