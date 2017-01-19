using UnityEngine;
using System.Collections;

public  class Personality_player  {

    // abstract class which is used for to create all of the personailts for the player for the game. This way they all can use the dame functions to access the information when the player selects it

    public string Name;
    public string intro;

    public string questiontype1;
    public string question1;

    public string questiontype2;
    public string question2;

    public string questiontype3;
    public string question3;

	public string questiontype4;
	public string question4;

    public string accuse;



    // INTRO 
    public void setintro(string newintro)
    {
        intro = newintro;
    }

    public string Intro()
    {
        return intro;
    }


    // QUESTION SET 1 
    public void set1(string new1)
    {
        question1 = new1;
    }
    public void settype1(string type1)
    {
        questiontype1 = type1;
    }
    public string Question1()
    {
        return question1;
    }
    public string type1()
    {
        return questiontype1;
    }


    // QUESTION SET 2 
    public void settype2( string new2)
    {
        questiontype2 = new2;
    }

    public string type2()
    {
        return questiontype2;
    }

    public string Question2()
    {
        return question2;
    }

    public void set2(string new1)
    {
        question2 = new1;
    }

    // QUESTION SET 3 

    public void settype3(string new3)
    {
        questiontype3 = new3;
    }

    public string type3()
    {
        return questiontype3;
    }

    public string Question3()
    {
        return question3;
    }

    public void set3(string new1)
    {
        question3 = new1;
    }

	// QUESTION SET 4

	public void settype4(string new4)
	{
		questiontype4 = new4;
	}

	public string type4()
	{
		return questiontype4;
	}

	public string Question4()
	{
		return question4;
	}

	public void set4(string new4)
	{
		question4 = new4;
	}



    // ACCUSE 
    public void setAccuse(string newaccuse)
    {
        accuse = newaccuse;
    }

    public string Accuse()
    {
        return accuse;
    }
}
