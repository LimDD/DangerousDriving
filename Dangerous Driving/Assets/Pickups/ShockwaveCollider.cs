using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockwaveCollider : MonoBehaviour
{
    public HealthBar hb;
    void OnParticleCollision(GameObject other)
    {
        hb.UpdateHealth(-1);
    }
}
