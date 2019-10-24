using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject car;
    public Image ImgHealthBar;
    public Text TxtHealth;
    public int Min;
    public int Max;
    public float newhealth;
    public float currenthealth;
    public float percentage;
    public bool healthRemaining;
    public Transform player;
    public Transform respawnPoint;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        
        healthRemaining = true;
        SetHealth(100);
    }

    public void UpdateHealth(float value)
    {
        newhealth = currenthealth + value;
        SetHealth(newhealth);
    }

    IEnumerator Respawn()
        {
            
            yield return new WaitForSeconds(3);
            

        }

        public void SetHealth(float health) //define the current health

    {
        if(health != currenthealth)
        {
            if(Max - Min == 0)
            {
                currenthealth = 0;
                percentage = 0;
            } else
            {
                currenthealth = health;
                percentage = (float)currenthealth / (float)(Max - Min);
            }

            if (currenthealth > 100)
            {
                currenthealth = 100;
                percentage = 1;
            }

            
            if (health <= 0)
            {
                
                player.transform.position = respawnPoint.transform.position;
                SetHealth(100);
            } else
            {
                TxtHealth.text = string.Format("{0} %", Mathf.RoundToInt(percentage * 100));
                ImgHealthBar.fillAmount = (percentage);
            }

             
        }
    }

    public bool getHealthRemaining
    {
        get { return healthRemaining; }
    }

    public float CurrentPercent
    {
        get { return percentage; }
    }

    public float CurrentValue
    {
        get { return currenthealth; }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
