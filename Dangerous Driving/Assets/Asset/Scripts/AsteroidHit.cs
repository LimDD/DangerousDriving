using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHit : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject explosion;
    public Transform endOfAsteroid;
    private GameObject clone;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        if (rb.transform.position.x <= 1)
        {
            endOfAsteroid.position = rb.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        clone = Instantiate(this.explosion, endOfAsteroid.position, Quaternion.identity);

        Destroy(this.gameObject);

        if (clone) Destroy(clone, 1f);
    }
}
