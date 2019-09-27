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
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spike")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("AICar")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);
        }
    }
}
