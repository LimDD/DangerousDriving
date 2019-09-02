using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHit : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject prefab;
    public Vector3 position;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (this.gameObject == false)
        {
            position = new Vector3(Random.Range(1, 20), 50, Random.Range(1, 20));
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(prefab, position, Quaternion.identity);
        this.gameObject.SetActive(false);
    }
}
