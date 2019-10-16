using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollisions : MonoBehaviour
{
    public HealthBar hb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            other.gameObject.SetActive(false);

            hb.UpdateHealth(-3.0f);
        }

    }
}


