using UnityEngine;
using System.Collections;

public class CreateCrime : MonoBehaviour
{

    public GameObject gamemanob;


    public string crime;
    public string check_murder;
    public int murder_int; 

    public string murder1;
    public string murder2;
    public string murder3;
    public string murder4;
    public string murder5;

    public void select_crime()
    {
        int y = Random.Range(0, 3);  // 0 ,1 or 2 
        murder_int = y;
    }



    public void Set_Murder(int x ) // needs to be finished 
    {
        if (x == 0)
        {
            crime = murder1;
            check_murder = "stab_back";

        }
        else if (x == 1)
        {
            crime = murder2;
            check_murder = "drowned";

        }
        else if (x == 2)
        {
            crime = murder3;
            check_murder = "pushed_lakehouse";
        }
        else if (x == 3)
        {
            ;

        }
        else
        {
            ;

        }

    }

 

    public void set_murders()
    {
        // stabbed in the back murder
        murder1 = ("So we've heard from " + gamemanob.GetComponent<gameManager>().get_victim() + "'s family "
            + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was being extored for money by someone. \n\n " +
            gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was apparently meeting this individual at the Ron Cooke Hub today. \n\n"
            + gamemanob.GetComponent<gameManager>().get_victim() + "'s body was found satbbed in " + gamemanob.GetComponent<gameManager>().get_whole_victim().room);  // room set by the npc generator

        // pushed into the freeing lake 
        murder2 = ("The lake outside of the Ron Cooke Hub is cold at the best of times. Last night the lake wasnt far off being frozen.\n\n  " + gamemanob.GetComponent<gameManager>().get_victim() +
            "\'s body was found at the bottom, cold as ice \n\n It looks like " + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was pushed.");

        // pushed over the lakehouse 
        murder3 = ("The height of the lake house balcony is around 30 feet tall and " + gamemanob.GetComponent<gameManager>().get_victim()  + " feel all 30...head first. \n\n" +
            gamemanob.GetComponent<gameManager>().get_victim() + " can be found at " + gamemanob.GetComponent<gameManager>().get_whole_victim().room) ;

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
        Set_Murder(murder_int);
        load_crime();
        Debug.Log(crime);

    }




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}