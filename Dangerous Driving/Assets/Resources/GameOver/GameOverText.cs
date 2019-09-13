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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
