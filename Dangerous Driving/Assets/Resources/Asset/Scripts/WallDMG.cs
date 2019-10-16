using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDMG : MonoBehaviour
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            hb.UpdateHealth(-3f);
        }
    }
}
