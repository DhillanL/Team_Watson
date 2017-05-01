// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class logbookparts : MonoBehaviour {

    // info parts of the clues in the logbook
    public static string logbooktext1;
    public static string logbooktext2;
    public static string logbooktext3;
    public static string logbooktext4;
    public static string logbooktext5;
    public static string logbooktext6;
    public static string logbooktext7;
    public static string logbooktext8;
    public static string logbooktext1_2;
    public static string logbooktext2_2;
    public static string logbooktext3_2;
    public static string logbooktext4_2;
    public static string logbooktext5_2;
    public static string logbooktext6_2;
    public static string logbooktext7_2;
    public static string logbooktext8_2;
    public static string casefiletext;

    // number of clues found so far 
    public static int clue_count1 = 0;
    public static int clue_count2 = 0;

    // the log book TEXT elements that need to be added in the unity editor 
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;

    public GameObject text1_2;
    public GameObject text2_2;
    public GameObject text3_2;
    public GameObject text4_2;
    public GameObject text5_2;
    public GameObject text6_2;
    public GameObject text7_2;
    public GameObject text8_2;

    public GameObject casefiletextobj;

    public bool first_load = true;

    


    public void load_logbook()
    {
        if (first_load)
        {
            string[] logbooktexts = {"logbooktext1", "logbooktext2" , "logbooktext3" , "logbooktext4" , "logbooktext5",
            "logbooktext6","logbooktext7","logbooktext8","logbookcasetext"};
            for (int i =0; i < 9; i++)
            {
                logbooktexts[i] = "";
            }

            first_load = false;
        }

        text1.GetComponent<Text>().text = logbooktext1;
        text1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text2.GetComponent<Text>().text = logbooktext2;
        text2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text3.GetComponent<Text>().text = logbooktext3;
        text3.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text4.GetComponent<Text>().text = logbooktext4;
        text4.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text5.GetComponent<Text>().text = logbooktext5;
        text5.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text6.GetComponent<Text>().text = logbooktext6;
        text6.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text7.GetComponent<Text>().text = logbooktext7;
        text7.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text8.GetComponent<Text>().text = logbooktext8;
        text8.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

        text1_2.GetComponent<Text>().text = logbooktext1_2;
        text1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text2_2.GetComponent<Text>().text = logbooktext2_2;
        text2_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text3_2.GetComponent<Text>().text = logbooktext3_2;
        text3_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text4_2.GetComponent<Text>().text = logbooktext4_2;
        text4_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text5_2.GetComponent<Text>().text = logbooktext5_2;
        text5_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text6_2.GetComponent<Text>().text = logbooktext6_2;
        text6_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text7_2.GetComponent<Text>().text = logbooktext7_2;
        text7_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        text8_2.GetComponent<Text>().text = logbooktext8_2;
        text8_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        casefiletextobj.GetComponent<Text>().text = casefiletext;
       

    }

    public void add_clue(clue clue)
    { if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().get_player_turn() == 1)
        {
            if (clue.is_verbal == false)
            {
                if (clue_count1 == 0)
                {
                    GameObject.FindWithTag("logpic1").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext1 = clue.name;
                    logbooktext1 += "\n" + clue.getInfo();
                    increase_count();

                }
                else if (clue_count1 == 1)
                {
                    GameObject.FindWithTag("logpic2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext2 = clue.name;
                    logbooktext2 += "\n" + clue.getInfo();
                    increase_count();

                }
                else if (clue_count1 == 2)
                {
                    GameObject.FindWithTag("logpic3").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext3 = clue.name;
                    logbooktext3 += "\n" + clue.getInfo();
                    increase_count();

                }
                else if (clue_count1 == 3)
                {
                    GameObject.FindWithTag("logpic4").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext4 = clue.name;
                    logbooktext4 += "\n" + clue.getInfo();
                    increase_count();

                }
                else if (clue_count1 == 4)
                {
                    GameObject.FindWithTag("logpic5").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext5 = clue.name;
                    logbooktext5 += "\n" + clue.getInfo();
                    increase_count();
                }
                else if (clue_count1 == 5)
                {
                    GameObject.FindWithTag("logpic6").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext6 = clue.name;
                    logbooktext6 += "\n" + clue.getInfo();
                    increase_count();
                }
                else if (clue_count1 == 6)
                {
                    GameObject.FindWithTag("logpic7").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext7 = clue.name;
                    logbooktext7 += "\n" + clue.getInfo();
                    increase_count();
                }
                else
                {
                    GameObject.FindWithTag("logpic8").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext8 = clue.name;
                    logbooktext8 += "\n" + clue.getInfo();
                    increase_count();
                }
            }
            else   
            {
                if (clue_count1 == 0)
                {
                    GameObject.FindWithTag("logpic1").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext1 = clue.name;
                    increase_count();
                }
                else if (clue_count1 == 1)
                {
                    GameObject.FindWithTag("logpic2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext2 = clue.name;
                    increase_count();

                }
                else if (clue_count1 == 2)
                {
                    GameObject.FindWithTag("logpic3").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext3 = clue.name;
                    increase_count();
                }
                else if (clue_count1 == 3)
                {
                    GameObject.FindWithTag("logpic4").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext4 = clue.name;
                    increase_count();
                }
                else if (clue_count1 == 4)
                {
                    GameObject.FindWithTag("logpic5").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext5 = clue.name;
                    increase_count();
                }
                else if (clue_count1 == 5)
                {
                    GameObject.FindWithTag("logpic6").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext6 = clue.name;
                    increase_count();
                }
                else if (clue_count1 == 6)
                {
                    GameObject.FindWithTag("logpic7").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext7 = clue.name;
                    increase_count();
                }
                else
                {
                    GameObject.FindWithTag("logpic8").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext8 = clue.name;
                    increase_count();
                }
            }
        } else    // else if its player 2 who clicks on the clue 
        {
            if (clue.is_verbal == false)
            {
                if (clue_count2 == 0)
                {
                    GameObject.FindWithTag("logpic1_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext1_2 = clue.name;
                    logbooktext1_2 += "\n" + clue.getInfo();
                    increase_count2();

                }
                else if (clue_count2 == 1)
                {
                    GameObject.FindWithTag("logpic2_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext2_2 = clue.name;
                    logbooktext2_2 += "\n" + clue.getInfo();
                    increase_count2();

                }
                else if (clue_count2 == 2)
                {
                    GameObject.FindWithTag("logpic3_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext3_2 = clue.name;
                    logbooktext3_2 += "\n" + clue.getInfo();
                    increase_count2();

                }
                else if (clue_count2 == 3)
                {
                    GameObject.FindWithTag("logpic4_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext4_2 = clue.name;
                    logbooktext4_2 += "\n" + clue.getInfo();
                    increase_count2();

                }
                else if (clue_count2 == 4)
                {
                    GameObject.FindWithTag("logpic5_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext5_2 = clue.name;
                    logbooktext5_2 += "\n" + clue.getInfo();
                    increase_count2();
                }
                else if (clue_count2 == 5)
                {
                    GameObject.FindWithTag("logpic6_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext6_2 = clue.name;
                    logbooktext6_2 += "\n" + clue.getInfo();
                    increase_count2();
                }
                else if (clue_count2 == 6)
                {
                    GameObject.FindWithTag("logpic7_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext7_2 = clue.name;
                    logbooktext7_2 += "\n" + clue.getInfo();
                    increase_count2();
                }
                else
                {
                    GameObject.FindWithTag("logpic8_2").GetComponent<SpriteRenderer>().sprite = clue.look;
                    logbooktext8_2 = clue.name;
                    logbooktext8_2 += "\n" + clue.getInfo();
                    increase_count2();
                }
            }
            else
            {
                if (clue_count2 == 0)
                {
                    GameObject.FindWithTag("logpic1_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext1_2 = clue.name;
                    increase_count2();
                }
                else if (clue_count2 == 1)
                {
                    GameObject.FindWithTag("logpic2_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext2_2 = clue.name;
                    increase_count2();

                }
                else if (clue_count2 == 2)
                {
                    GameObject.FindWithTag("logpic3_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext3_2 = clue.name;
                    increase_count2();
                }
                else if (clue_count2 == 3)
                {
                    GameObject.FindWithTag("logpic4_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext4_2 = clue.name;
                    increase_count2();
                }
                else if (clue_count2 == 4)
                {
                    GameObject.FindWithTag("logpic5_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext5_2 = clue.name;
                    increase_count2();
                }
                else if (clue_count2 == 5)
                {
                    GameObject.FindWithTag("logpic6_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext6_2 = clue.name;
                    increase_count2();
                }
                else if (clue_count2 == 6)
                {
                    GameObject.FindWithTag("logpic7_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext7_2 = clue.name;
                    increase_count2();
                }
                else
                {
                    GameObject.FindWithTag("logpic8_2").GetComponent<SpriteRenderer>().sprite = clue.npc_verbal.headshot;
                    logbooktext8_2 = clue.name;
                    increase_count2();
                }
            }
        }
    }

    public void increase_count()
    {
		// clue_obtained = true; Does this need to be here?
        clue_count1++;
    }

    public void increase_count2()
    {
        // clue_obtained = true; Does this need to be here?
        clue_count2++;
    }

    public void reset_clues()
    {
        logbooktext1 = "";
        logbooktext2 = "";
        logbooktext3 = "";
        logbooktext4 = "";
        logbooktext5 = "";
        logbooktext6 = "";
        logbooktext7 = "";
        logbooktext8 = "";
        clue_count1 = 0;
        

    }

    public string getlogbooktext1()
    {
        return logbooktext1;
    }


    public void load_log_book_crime(string text)
    {
        casefiletext = text;
    }
  
}
