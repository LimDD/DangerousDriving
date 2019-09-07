using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    public int currenthealth;
    public string currenttime;
    public int currentlap;
    public bool gamestatus;

    public LapTimer lt;
    public LapNumber ln;
    public HealthBar hb;

    public PassStatistics ps;

    public void startgame()
    {
        lt.SetStartTimerOn(); //start lap timer
        setcurrentlap(1);
        ln.SetLapNumber(currentlap); //set currentlap to 1
    }

    public void setgamestatus(bool value)
    {
        gamestatus = value;
    }

    public void setcurrenthealth(int value)
    {
        currenthealth = value;
    }

    public void setcurrenttime(string value)
    {
        currenttime = value;
    }

    public void setcurrentlap(int value)
    {
        currentlap = value;
    }

    public int getcurrenthealth
    {
        get { return currenthealth; }
    }

    public string getcurrenttime
    {
        get { return currenttime; }
    }

    public int getcurrentlap
    {
        get { return currentlap; }
    }

    public bool getgamestatus
    {
        get { return gamestatus; }
    }

    // Start is called before the first frame update
    void Start()
    {
        setcurrentlap(0);
        setcurrenttime("00 : 00: 00");
        setcurrenthealth(50);
        gamestatus = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gamestatus == false) //game status false means game over
        {
            setcurrenthealth(hb.CurrentValue); //get current health
            setcurrenttime(lt.getcurrenttime); //get current time
            setcurrentlap(ln.CurrentLapNumber); //get current lap
            ps.setstatistics(currenthealth, currentlap, currenttime); //pass data to script

            SceneManager.LoadScene(2); //index2 = 'GameOver' scene
        }
    }
}
