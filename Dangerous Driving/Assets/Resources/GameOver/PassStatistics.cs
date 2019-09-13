using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PassStatistics : MonoBehaviour
{

    public int health;
    public int lap;
    public string time;

    // Start is called before the first frame update

    private void Start()
    {
        
    }


    void Awake()
    {
        Object.DontDestroyOnLoad(this.gameObject);
    }

    public void setstatistics(int healthvalue, int lapvalue, string timevalue)
    {
        health = healthvalue;
        lap = lapvalue;
        time = timevalue;
    }

    public int gethealth
    {
        get { return health; }
    }

    public int getlap
    {
        get { return lap; }
    }

    public string gettime
    {
        get { return time; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
