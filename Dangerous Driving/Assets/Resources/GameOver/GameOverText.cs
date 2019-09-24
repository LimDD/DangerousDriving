using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverText : MonoBehaviour
{
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Lap;
    public TextMeshProUGUI Time;
    public TextMeshProUGUI Score;

    public int health;
    public int lap;
    public string time;
    public int seconds;
    public int score;

    public PassStatistics ps;
    public GameObject go;    
    public PassStatistics somescript;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("GameObject");
        somescript = (PassStatistics)go.GetComponent(typeof(PassStatistics));

        health = somescript.gethealth;
        lap = somescript.getlap;
        time = somescript.gettime;

        calculateScore();

        Health.text = "Health: " + health.ToString() + "%";
        Lap.text = "LAP: " + lap + "/1";
        Time.text = time;
        Score.text = "Score: " + score;
    }

    public void calculateScore()
    {
        char minutesTens = time[0];
        int mT = (int)minutesTens;
        mT += -48;

        char minutesOnes = time[1];
        int mO = (int)minutesOnes;
        mO += -48;

        char secondsTens = time[5];
        int sT = (int)secondsTens;
        sT += -48;

        char secondsOnes = time[6];
        int sO = (int)secondsOnes;
        sO += -48;

        if (mT != 0)
        {
            seconds += mT * 600;
        }

        if (mO != 0)
        {
            seconds += mO * 60;
        }

        if (sT != 0)
        {
            seconds += sT * 10;
        }

        seconds += sO;

        score = (health*2) - seconds;

        if (score < 0)
        {
            score = 0;  //minimum score 0
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
