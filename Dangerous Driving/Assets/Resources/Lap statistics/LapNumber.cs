using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapNumber : MonoBehaviour
{
    public Text LapNumberText;
    public int CurrentLapNumber;
    public int TotalLaps;
    // Start is called before the first frame update
    void Start()
    {
        CurrentLapNumber = 0;
        TotalLaps = 1;
    }

    public void SetLapNumber(int value)
    {
        if (CurrentLapNumber != value)
        {
            CurrentLapNumber = value;
            LapNumberText.text = string.Format("Lap: " +CurrentLapNumber+ "/" +TotalLaps);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
