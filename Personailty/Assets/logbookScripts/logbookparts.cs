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

    // number of clues found so far 
    public static int clue_count = 0;

    // the log book TEXT elements that need to be added in the unity editor 
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;


    public void load_logbook()
    {
        text1.GetComponent<Text>().text = logbooktext1;
        text2.GetComponent<Text>().text = logbooktext2;
        text3.GetComponent<Text>().text = logbooktext3;
        text4.GetComponent<Text>().text = logbooktext4;
        text5.GetComponent<Text>().text = logbooktext5;
        text6.GetComponent<Text>().text = logbooktext6;
        text7.GetComponent<Text>().text = logbooktext7;
        text8.GetComponent<Text>().text = logbooktext8;
    }

    public void add_clue(clue clue)
    {
        if (clue_count == 0)
        {
            GameObject.FindWithTag("logpic1").GetComponent<SpriteRenderer>().sprite = clue.look;
            logbooktext1 = clue.name;
            logbooktext1 += "\n"+clue.getInfo();
            increase_count();

        } else if (clue_count == 1)
        {
            GameObject.FindWithTag("logpic2").GetComponent<SpriteRenderer>().sprite = clue.look;
            logbooktext2 = clue.name;
            logbooktext2 += "\n" + clue.getInfo();
            increase_count();

        } else if (clue_count == 2 )
        {
            logbooktext3 = clue.name;
            logbooktext3 += "\n" + clue.getInfo();
            increase_count();

        } else if (clue_count == 3 )
        {
            logbooktext4 = clue.getInfo();
            increase_count();

        } else if (clue_count == 4 )
        {
            logbooktext5 = clue.getInfo();
            increase_count();
        } else if (clue_count == 5)
        {
            logbooktext6 = clue.getInfo();
            increase_count();
        } else if  (clue_count == 6)
        {
            logbooktext7 = clue.getInfo();
            increase_count();
        } else
        {
            logbooktext8 = clue.getInfo();
            increase_count();
        }
    }

    public void increase_count()
    {
        clue_count++;
    }




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
