using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDMG : MonoBehaviour
{
    public HealthBar health;
    
    void Start()
    {

    }

    void Update()
    {

    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spike")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);
        }
        if (other.CompareTag("AICar")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);

            yield return new WaitForSeconds(3);
        }
    }
}
