using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHit : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        /* if (other.gameObject.CompareTag("Track"))
         {
             this.gameObject.SetActive(false);
         }
         */
        Destroy(this.gameObject);
    }
}
