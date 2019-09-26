using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDMG : MonoBehaviour
{
    public HealthBar health;
    public CarController speed;
    void Start()
    {
        
    }
   
    void Update()
    {
        
    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spike"))
        {
            health.UpdateHealth(-10.0f);
            
            yield return new WaitForSeconds(3);
        }
    }
}
