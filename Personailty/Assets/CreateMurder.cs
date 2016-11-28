using UnityEngine;
using System.Collections;

public class CreateMurder : MonoBehaviour {

    public GameObject gamemanob;
    

    public string crime;

    public string murder1;
    public string murder2;
    public string murder3;
    public string murder4;
    public string murder5; 

    public void getMurder() // needs to be finished 
    {
        int x = Random.Range(0, 3);
        if (x == 0)
        {
            crime = murder1;

        } else if (x==1)
        {
            ;

        } else if (x==2)
        {
            ;
        } else if (x==3)
        {
            ;

        } else
        {
            ;

        }
        
    }

    public void set_murders()
    {
        murder1 = ("So we've heard from " + gamemanob.GetComponent<gameManager>().get_victim() + "'s family " 
            + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she  + " was being extored for money by someone. \n\n "+ 
            gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was apparently meeting this individual at the Ron Cooke Hub today. \n\n"
            + gamemanob.GetComponent<gameManager>().get_victim() + "'s body was found satbbed in " + gamemanob.GetComponent<gameManager>().get_whole_victim().room);  // room set by the npc generator

        murder2 = ("hello");
    }

    public string get_murder()
    {
        return crime;
    }

    public void load_crime()
    {
        gamemanob.GetComponent<gameManager>().set_crime(crime);
    }

    public void create_crime()
    {
        set_murders();
        crime = murder1; // replace with random after a while 
        load_crime();
        Debug.Log(crime);
    }




    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
