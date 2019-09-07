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

    public int health;
    public int lap;
    public string time;

    public PassStatistics ps;

    // Start is called before the first frame update
    void Start()
    {
        health = ps.gethealth;
        lap = ps.getlap;
        time = ps.gettime;

        Health.text = "Remaining health: " + health.ToString() + "%";
        Lap.text = "LAP: " + lap + "/1";
        Time.text = time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
