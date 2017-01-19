using UnityEngine;
using System.Collections;

public class CreateCrime : MonoBehaviour
{
    /*
     * CreateCrime  is used to create the crime for the game randomy. it is called by createNPC during the setup for the game
     */

    public GameObject gamemanob;


    // variables used for the CreateCrime
    public string crime;
    public int murder_int; 

    public string murder1;
    public string murder2;
    public string murder3;
    public string murder4;
    public string murder5;
    public string murder6;
    public string murder7;
    public string murder8;
    public string murder9;
    public string murder10;


    public void select_crime() // random number to select which murder will take place 
    {
        int y = Random.Range(0, 10); 
        murder_int = y;
    }



    public void Set_Murder(int x ) // using the random number selected set the murder  
    {
        if (x == 0)
        {
            crime = murder1;
            

        }
        else if (x == 1)
        {
            crime = murder2;
            

        }
        else if (x == 2)
        {
            crime = murder3;
           
        }
        else if (x == 3)
        {
            crime = murder4;
           
        }
        else if (x == 4)
        {
            crime = murder5;
            
        }
        else if (x == 5)
        {
            crime = murder6;
        }
        else if (x == 6)
        {
            crime = murder7;
        }
        else if (x == 7)
        {
            crime = murder8;
        }
        else if (x ==8)
        {
            crime = murder9;
        }
        else if (x == 9)
        {
            crime = murder10;
        }

    }

 

    public void set_murders()
    {
        // stabbed in the back murder - extored
        murder1 = ("So we've heard from " + gamemanob.GetComponent<gameManager>().get_victim() + "'s family "
            + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was being extored for money by someone. \n\n " +
            gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was apparently meeting this individual at the Ron Cooke Hub today. \n\n"
            + gamemanob.GetComponent<gameManager>().get_victim() + "'s body was found satbbed in " + gamemanob.GetComponent<gameManager>().get_whole_victim().room);  // room set by the npc generator

        // pushed into the freeing lake 
        murder2 = ("The lake outside of the Ron Cooke Hub is cold at the best of times. Last night the lake wasnt far off being frozen.\n\n  " + gamemanob.GetComponent<gameManager>().get_victim() +
            "\n's body was found at the bottom, cold as ice \n\nIt looks like " + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was pushed.");

        // pushed over the lakehouse 
        murder3 = ("The height of the lake house balcony is around 30 feet tall and " + gamemanob.GetComponent<gameManager>().get_victim()  + " feel all 30...head first. \n\n" +
            gamemanob.GetComponent<gameManager>().get_victim() + " can be found at " + gamemanob.GetComponent<gameManager>().get_whole_victim().room) ;

        // strangled by a scarf
        murder4 = (gamemanob.GetComponent<gameManager>().get_victim() + "'s body was found in " + gamemanob.GetComponent<gameManager>().get_whole_victim().room
            + "\n " + gamemanob.GetComponent<gameManager>().get_whole_victim().he_she + " was found strangled by a scraf");

        //posioned
        murder5 = (gamemanob.GetComponent<gameManager>().get_victim() + "s teeth were black their tounge swollen. They were poisoned \n\n The body is in " + gamemanob.GetComponent<gameManager>().get_whole_victim().room);

        // shot in the neck with an arrow  

        murder6 = "victim shot in the back of the neck with an arrow";

        // throat was cut - rumor is that he/she was having an affair

        murder7 = "The victim has had their throat slit, so the kill was silent \n Nobdy even found the body for quite a while";

        // crushed by chandelier

        murder8 = "the victim was crushed under the weight of the chandelier.\n The chandelier has since been removed \n worth noting there were a lot of people witness to the death";

        // murder 9 
        murder9 = "The victims body was found in the fire, but they had already been stabbed a few times it seems ";

        // murder 10 

        murder10 = "The victim has been found wihtout a heart in the middle of the floor looking like a tricky one";


    }

    public string get_murder() // accessor to return the crime type
    {
        return crime;
    }

    public void load_crime()  //loads crime into the gamemanager 
    {
        gamemanob.GetComponent<gameManager>().set_crime(crime);
    }

    public void create_crime() //function to create the crime and set the murderer
    {
        set_murders();
        Set_Murder(murder_int);
        load_crime();
        Debug.Log(crime);

    }

}