using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image ImgHealthBar;
    public Text TxtHealth;
    public int Min;
    public int Max;
    public float newhealth;
    public float currenthealth;
    public float percentage;

    public void UpdateHealth(float value)
    {
        newhealth = currenthealth + value;
        SetHealth(newhealth);
    }

    public void sethealthfloat(float value)
    {

    }

    public void SetHealth(float health) //define the current health
    {
        if(health != currenthealth)
        {
            if(Max - Min == 0)
            {
                currenthealth = 0;
                percentage = 0;
            }
            else
            {
                currenthealth = health;
                percentage = (float)currenthealth / (float)(Max - Min);
            }

            TxtHealth.text = string.Format("{0} %", Mathf.RoundToInt(percentage * 100));

            ImgHealthBar.fillAmount = (percentage);
        }
    }

    public float CurrentPercent
    {
        get { return percentage; }
    }

    public float CurrentValue
    {
        get { return currenthealth; }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
