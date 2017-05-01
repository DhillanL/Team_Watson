// WHOLE SCRIPT IS NEW FOR ASSESSMENT 4 
// ALL PROCEDURES ARE USED TO LOAD IN THE LOCKS INTO THE GAME TO SOLVE TO GET INTO THE HIDDEN ROOM. 
// THE FINAL EXE FOR THE GAME CAN BE FOUND AT: github.com/DhillanL/Team_Watson

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Makelocks : MonoBehaviour {

    // ALL THE ATTRIUBTES TO BUILD THE LOCOK FROM  
    public GameObject Lockbarrell;
    public GameObject lockgreen;
    public GameObject lockorange;
    public GameObject lockline;
    public GameObject rightcollider;

    public GameObject holder;   // hold the temp green marker 
    public GameObject lock1;

    public GameObject lockanim;

    // UI ELEMENTS 
    public Text pass_fail;
    public Text pin1;
    public Text pin2;
    public Text pin3;
   

    private bool gameplaying = true;

    int locknumber = 1;

    int miss = 0;  // how many times you miss the lock 

    // coordinate positions for the locks so the line can be placed correctly and tested if it goes in the green
    public float greenposx;
    public float greenposy;
    public float greenposz;


    public void makelock(GameObject Lock,int pos )   // creates the first barrell and line for the lock 
    {

        Lock.transform.position = new Vector3(0, pos, 0);

        GameObject Barrell = Instantiate(Lockbarrell) as GameObject;  // makes an instatce of the barrllel from the already created one 
        Barrell.transform.parent = Lock.transform;
        GameObject Line = Instantiate(lockline) as GameObject;
        Line.transform.parent = Lock.transform;

        Barrell.transform.position = Lock.transform.position;
        
        Line.transform.position = new Vector3(Lock.transform.position.x - 130, Lock.transform.position.y, Lock.transform.position.z);  //set it to teh right position 
    }

    public void makeGreen(GameObject Lock)      // will make the green targets in a random place along the lock 
    {
        GameObject GreenTarget = Instantiate(holder) as GameObject;

        GameObject Green = Instantiate(lockgreen) as GameObject;
        Green.transform.parent = GreenTarget.transform;
        GameObject orangeR = Instantiate(lockorange) as GameObject;
        orangeR.transform.parent = GreenTarget.transform;
        GameObject orangeL = Instantiate(lockorange) as GameObject;
        orangeL.transform.parent = GreenTarget.transform;
        GameObject Line = Instantiate(lockline) as GameObject;
        Line.transform.parent = GreenTarget.transform;  // create all the green and oraznge parts to add to the lock barrell

        int rand = Random.Range(-110, 110);
        greenposx = Lock.transform.position.x + rand;
        greenposy = Green.transform.position.y;
        greenposz = Green.transform.position.z;

        Green.transform.position = new Vector3(Lock.transform.position.x + rand, Lock.transform.position.y, Lock.transform.position.z);
        orangeL.transform.position = new Vector3(Green.transform.position.x - 11, Green.transform.position.y, Green.transform.position.z);
        orangeR.transform.position = new Vector3(Green.transform.position.x + 11, Green.transform.position.y, Green.transform.position.z);
        // put the green in a random place in the barrell and then put the orange either side of it 


        GreenTarget.transform.parent = Lock.transform;

    }

    public int getlocknumber()   // returns the lock number 
    {
        return locknumber;
    }

    public void playlock(GameObject Lock, int speed)    // starts the lock line moving 
    {
        Rigidbody2D rb;
        Lock.transform.FindChild("lockline(Clone)").GetComponent<speed>().set_speed(speed);
        rb = Lock.transform.FindChild("lockline(Clone)").GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(speed, 0);  // set the line so it starts moving 
    }


    public void stopline(GameObject Lock)    // stops the lock line moving 
    {
        Rigidbody2D rb;

        rb = Lock.transform.FindChild("lockline(Clone)").GetComponent<Rigidbody2D>();
        
        rb.velocity = new Vector2(0, 0);  // set the velocity of the line to zero
    }


    public void destorygreen(GameObject Lock)   // destorys the green target 
    {

        GameObject obj = Lock.transform.Find("Greenlock(Clone)").gameObject;
        Destroy(obj);
    }

    public void destorylock()   // destroys the whoel lock 
    {
        GameObject obj = GameObject.FindWithTag("lock");
        Destroy(obj);

    }

    public void stopgame()    // stops the game when the player misses 
    {
        gameplaying = false;
    }

    public void setpintext(Text pin,bool result)   // set the dispaly text to either win or lose when the result is calculated 
    {
        if (result == true)
        {
            pin.text += " Pass";
            pin.color = Color.green;
        } else
        {
            pin.text += " Fail";
            pin.color = Color.red;
        }
    }

    public void startlock1()  // starts the first lock 
    {
        playlock(lock1, 70);

    }
    

    public void startlock2()   // starts the second look at a faster speed 
    {
        destorygreen(lock1);
        miss++;   // accounts for the latency in the collider boxes 
        makeGreen(lock1);
        playlock(lock1, 110);
        setpintext(pin1,true);
        lockanim.GetComponent<Animator>().SetInteger("state", 1);   // chnages the state of the aniamtaion 
        locknumber++;
    }

    public void startlock3()   // starts the third and final lock at the fastest speed. 
    {
        destorygreen(lock1);
        miss++;
        makeGreen(lock1);
        playlock(lock1, 140);
        setpintext(pin2, true);
        lockanim.GetComponent<Animator>().SetInteger("state", 2);   // chnages the state of the aniamtaion 
        locknumber++;
    }

    public void lock_picked(bool b)  // at the end  its tested if the player wins or not to display result
    {
        if (b.Equals(true))
        {
            setpintext(pin3,true);
            pass_fail.text += " - Open";
            pass_fail.color = Color.green;
            lockanim.GetComponent<Animator>().SetBool("finished", true);
            StartCoroutine(load_hidden_room());

        } else
        {
            pass_fail.text += "- Failed";
            pass_fail.color = Color.red;
            StartCoroutine(leavepage());
        }
    }

    IEnumerator leavepage()  // main game loop for the turn based game
    {
        yield return new WaitForSeconds(3);
        GameObject.FindWithTag("Player").GetComponent<Transform>().position = new Vector3(-80,-21,0);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_lakehousebalcony();
        if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().istwoplayeron())
        {
            GameObject.FindWithTag("turn").GetComponent<turnswitcher>().start_loop();
        }
        
    }

    IEnumerator load_hidden_room()  // loasd shte hidden room if the player solves the puzzle
    {
        yield return new WaitForSeconds(2);
        GameObject.FindWithTag("Player").GetComponent<Transform>().position = new Vector3(-80, -21, 0);
        if (GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().istwoplayeron())
        {
            GameObject.FindWithTag("turn").GetComponent<turnswitcher>().start_loop(); 
        }
        
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_hiddenroom();
    }

    public void set_line_green()
    {
        lockline.GetComponent<Transform>().position = new Vector3(greenposx,greenposy,greenposz);
    }

    public void set_line_fail()
    {
        lockline.GetComponent<Transform>().position = new Vector3(greenposx+30, greenposy, greenposz);
    }


    // Use this for initialization
    void Start () {
        makelock(lock1,-30);   // make the lock on the screen
        makeGreen(lock1);    // set the first green target for the lock 

        startlock1();       // start the line moving 
    }

    void Update()  // checks whenthe player misses the green target. 
    {
        if (gameplaying)
        {
            if (Input.GetMouseButtonDown(0))  // if the player clicks 
            {
                miss--;
            }
            if (miss < 0)
            {
                stopline(lock1);
                if (locknumber == 1)  // checks which lock the player is currently trying to solve 
                {
                    setpintext(pin1, false);
                    set_line_fail();
                } else if (locknumber == 2)
                {
                    setpintext(pin2, false);
                    set_line_fail();
                } else
                {
                    setpintext(pin3, false);
                    set_line_fail();
                }
                
                
                lockanim.GetComponent<Animator>().SetBool("checking",false);   // chnages the state of the aniamtaion 
                
                lock_picked(false);
                stopgame();  // stops the game 
                
            }
        }
    }

}
