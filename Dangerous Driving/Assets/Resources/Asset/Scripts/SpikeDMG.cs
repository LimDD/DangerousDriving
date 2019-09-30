using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SpikeDMG : MonoBehaviour
{
    public HealthBar health;
    CarController car;
    void Start()
    {
        car = this.GetComponent<CarController>(); // Get the componenet from this gameobject
    }

    void Update()
    {

    }

    private void RemoveSlowDebuff()
    {
        car.m_Topspeed /= 0.5f; // Reverse the slow by dividing
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spike")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);
            car.m_Topspeed = car.m_Topspeed * 0.5f; // Slow down the car by decreasing its max speed
            Invoke("RemoveSlowDebuff", 3f);
        }
        //else if (other.c)
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("AICar")) //tag on the object you collide with
        {
            health.UpdateHealth(-10.0f);
        }
    }
}
