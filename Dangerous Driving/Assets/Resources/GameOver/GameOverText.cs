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
        
        Debug.Log(time.ToString());

        Health.text = "Health: " + health.ToString() + "%";
        Lap.text = "LAP: " + lap + "/1";
        Time.text = time;
        Score.text = "Score: " + score;
    }

    public void calculateScore()
    {
        int minutesTens = time[7];
        int minutesOnes = time[8];
        int secondsTens = time[12];
        int secondsOnes = time[11];

        if (minutesTens != 0)
        {
            seconds += minutesTens * 600;
        }

        if (minutesOnes != 0)
        {
            seconds += minutesOnes * 60;
        }

        if (secondsTens != 0)
        {
            seconds += secondsTens * 10;
        }

        seconds += secondsOnes;

        int remainingHealth = 100 - health;
        score = (remainingHealth * 2) - seconds;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
