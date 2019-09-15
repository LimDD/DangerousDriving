﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinish : MonoBehaviour
{
    public bool startline;
    public bool trigger1;
    public bool finishline;
    public Statistics stats;

    //public Timer t;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StartFinish"))
        {
            if (startline == false)
            {
                startline = true;
                stats.startgame(); //starts lap number, timer
            }

        }

        if (other.CompareTag("Trigger1"))
        {
            trigger1 = true; //trigger1 true
        }

        if (other.CompareTag("StartFinish"))
        {
            if (trigger1 == true) 
            {
                stats.setgamestatus();
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        startline = false;
        trigger1 = false;
        finishline = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}