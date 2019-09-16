﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimer : MonoBehaviour
{
    public Text LapTimerText;
    public float startTimer = 0;
    public float time;
    public string timestring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetStartTimerOn()
    {
        startTimer = 1.0f;
    }

    public string getcurrenttime
    {
        get { return timestring; }
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer > 0)
        {
            time += Time.deltaTime;

            var minutes = time / 60;
            var seconds = time % 60;
            var milliseconds = (time * 100) % 100;

            //update label value
            LapTimerText.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, milliseconds);
            timestring = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, milliseconds);
        }
        else
        {
            //do nothing
        }
    }
}
