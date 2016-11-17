using UnityEngine;
using System.Collections;

public class CreateNPC : MonoBehaviour {

    public gameManager Gameman;

    public NPC Tonald_Dump = new NPC();    //all test names for NPC
    public NPC Bernard_lowe = new NPC();
    public NPC George_allen = new NPC();
    public NPC Ethan_hawk = new NPC();

    public NPC[] npc_list = new NPC[4];        // lists for selecting a murder and a victim ... will need to make correct size when all NPC's are in the game 
    public NPC[] npc_list_vic = new NPC[3];
   


   
    public void make_tonald()   // set of tonalds attrutes 
    {
        Tonald_Dump.Name = "Tonald Dump";
        Tonald_Dump.intro = "I want to build a wall!";
    }

    public void make_bernard()   // set bernards 
    {
        Bernard_lowe.Name = "Bernard Lowe";
        Bernard_lowe.intro = "My name is bernard, I like lamps";
    }

    public void make_George()
    {
        George_allen.Name = "George";
        
    }

    public void make_Ethan()
    {
        Ethan_hawk.Name = "Ethan";
        
    }




    public void makelst()   //create a list of the npc's
    {
        npc_list[0] = Tonald_Dump;
        npc_list[1] = Bernard_lowe;
        npc_list[2] = George_allen;
        npc_list[3] = Ethan_hawk;
        
    }


    public NPC get_tonald()
    {
        return Tonald_Dump;
    }

    public NPC get_bernard()
    {
        return Bernard_lowe;
    }




    public void set_murderer_and_victim()    //sets a NPC to be ther murder and a differnt npc to be the victim 
    {
        int x = Random.Range(0, 4);   // random number between 0 and 3
        npc_list[x].isMurder();       // get npc at x in the array and set to muderer
        Gameman.GetComponent<gameManager>().set_murder(npc_list[x]);    // store data in game manager 
        lst_no_murder();   // create list of all other npcs 
        int y = Random.Range(0, 3);   // pick number 
        npc_list_vic[y].is_Victim();   // set as victim 
        Gameman.GetComponent<gameManager>().set_victim(npc_list_vic[y]);  // store data 

    }

    public void lst_no_murder()   // creates a list of all other npcs who are not the murder. 
    {
        int y = 0;
        for (int x =0; x < npc_list.Length; x++)
        {
            if (npc_list[x].is_muderer == false)
            { 
                npc_list_vic[y] = npc_list[x];
                y++;
            } else
                ;
        }
    }


    public void Make_NPC() // called when initilased so to create all of the NPC's 
    {
        make_tonald();
        make_bernard();
        make_Ethan();
        make_George();
        makelst();
        set_murderer_and_victim();
    }
   



	// Use this for initialization
	void Start () {
        Make_NPC();
        Debug.Log("the murderer is: " + Gameman.GetComponent<gameManager>().get_murder());
        Debug.Log("the victim is: " + Gameman.GetComponent<gameManager>().get_victim());

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
