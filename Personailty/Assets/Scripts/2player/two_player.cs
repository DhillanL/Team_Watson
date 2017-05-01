// WHOLE SCRIPT IS NEW FOR ASSESSMENT 4  ALL CHNAGES MEET THE NEW UPDATED REQUIREMENTS TO ADD A TWO PLAYER ELEMET TO THE GAME 
// PROCEDURES AND COROUTIENS HAVE BEEN ADDED TO IMPLEMENT IT 
// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class two_player : MonoBehaviour {

    public GameObject createpersonobj;

    public InputField playe1name;
    public InputField playe2name;

    // buttons for the personalites so that when they are clicked on it selects the personaility for the player 
    public Button good1;
    public Button good2;
    public Button bad1;
    public Button bad2;
    public Button susp1;
    public Button susp2;
    public Button dumb1;
    public Button dumb2;
    public Button smart1;
    public Button smart2;
    public Button trust1;
    public Button trust2;


    public Button current_button1 = null;   
    public Button current_button2 = null;

    // ganmemmanger objects 
    public gameManager gamemanager;

    // procedures for all the buttons so that only one button is lit at a time 
    public void goodcop_but(int play)
    {
        if (play == 1)
        {
            good1.image.color = Color.red;
            if (current_button1 == null || current_button1 == good1)
            {
                current_button1 = good1;
            }  else
            {
                current_button1.image.color = Color.white;
                current_button1 = good1;
            }
        } else
        {
            good2.image.color = Color.red;
            if (current_button2 == null || current_button2 == good2)
            {
                current_button2 = good2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = good2;
            }
        }
    }

    public void badcop_but(int play)
    {
        if (play == 1)
        {
            bad1.image.color = Color.red;
            if (current_button1 == null || current_button1 == bad1)
            {
                current_button1 = bad1;
            }
            else
            {
                current_button1.image.color = Color.white;
                current_button1 = bad1;
            }
        }
        else
        {
            bad2.image.color = Color.red;
            if (current_button2 == null || current_button2 == bad2)
            {
                current_button2 = bad2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = bad2;
            }
        }
    }

    public void dumbcop_but(int play)
    {
        if (play == 1)
        {
            dumb1.image.color = Color.red;
            if (current_button1 == null || current_button1 == dumb1)
            {
                current_button1 = dumb1;
            }
            else
            {
                current_button1.image.color = Color.white;
                current_button1 = dumb1;
            }
        }
        else
        {
            dumb2.image.color = Color.red;
            if (current_button2 == null || current_button2 == dumb2)
            {
                current_button2 = dumb2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = dumb2;
            }
        }
    }

    public void smartcop_but(int play)
    {
        if (play == 1)
        {
            smart1.image.color = Color.red;
            if (current_button1 == null || current_button1 == smart1)
            {
                current_button1 = smart1;
            }
            else
            {
                current_button1.image.color = Color.white;
                current_button1 = smart1;
            }
        }
        else
        {
            smart2.image.color = Color.red;
            if (current_button2 == null || current_button2 == smart2)
            {
                current_button2 = smart2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = smart2;
            }
        }
    }

    public void suspcop_but(int play)
    {
        if (play == 1)
        {
            susp1.image.color = Color.red;
            if (current_button1 == null || current_button1 == susp1)
            {
                current_button1 = susp1;
            }
            else
            {
                current_button1.image.color = Color.white;
                current_button1 = susp1;
            }
        }
        else
        {
            susp2.image.color = Color.red;
            if (current_button2 == null || current_button2 == susp2)
            {
                current_button2 = susp2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = susp2;
            }
        }
    }

    public void trustcop_but(int play)
    {
        if (play == 1)
        {
            trust1.image.color = Color.red;
            if (current_button1 == null || current_button1 == trust1)
            {
                current_button1 = trust1;
            }
            else
            {
                current_button1.image.color = Color.white;
                current_button1 = trust1;
            }
        }
        else
        {
            trust2.image.color = Color.red;
            if (current_button2 == null || current_button2 == trust2)
            {
                current_button2 = trust2;
            }
            else
            {
                current_button2.image.color = Color.white;
                current_button2 = trust2;
            }
        }
    }

    // procedure which sets both the personailtes for the players 
    public void setplayers()
    {
        gamemanager.GetComponent<gameManager>().loadName(playe1name.text);
        gamemanager.GetComponent<gameManager>().setplayer2name(playe2name.text);
        createPersonalitys crepateperson = createpersonobj.GetComponent<createPersonalitys>();

        if (current_button1 == bad1)
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(1);
            Personality_player person = crepateperson.getBadCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);

        } else if (current_button1 == good1)
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(2);
            Personality_player person = crepateperson.getGoodCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);
        }
        else if (current_button1 == smart1)
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(3);
            Personality_player person = crepateperson.getSmartCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);
        }
        else if (current_button1 == dumb1)
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(4);
            Personality_player person = crepateperson.getDumbCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);
        }
        else if (current_button1 == trust1)
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(5);
            Personality_player person = crepateperson.getTrustyCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);
        }
        else 
        {
            gamemanager.GetComponent<gameManager>().loadpersonint(6);
            Personality_player person = crepateperson.getSuspCop();
            gamemanager.GetComponent<gameManager>().loadPersonailty(person);
        }

        if (current_button2 == bad2)
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(1);
            Personality_player person = crepateperson.getBadCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);

        }
        else if (current_button2 == good2)
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(2);
            Personality_player person = crepateperson.getGoodCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);
        }
        else if (current_button2 == smart2)
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(3);
            Personality_player person = crepateperson.getSmartCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);
        }
        else if (current_button2 == dumb2)
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(4);
            Personality_player person = crepateperson.getDumbCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);
        }
        else if (current_button2 == trust2)
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(5);
            Personality_player person = crepateperson.getTrustyCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);
        }
        else
        {
            gamemanager.GetComponent<gameManager>().setplayer2personint(6);
            Personality_player person = crepateperson.getSuspCop();
            gamemanager.GetComponent<gameManager>().loadpersonilty2(person);
        }
    }

    public void finish_but()
    {
        // ensures that you can only finish when all fields are filled in 
        if (playe1name.text == "" || playe2name.text == "" || current_button1 == null || current_button2 == null)
        {
            // do nothing - if all the feilds aren't full do nothing 
        }

        gamemanager.GetComponent<gameManager>().Twoplayeron();
        setplayers();
        gamemanager.GetComponent<gameManager>().load_case_file();

    }

}
