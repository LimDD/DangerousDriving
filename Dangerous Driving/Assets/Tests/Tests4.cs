using System.Collections;
using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests4
    {
        [UnityTest]
        public IEnumerator SpikeDMGTest()
        {
            GameObject car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));
            GameObject healthBarGameObject = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Scripts/HealthBar"));
            GameObject spikeStripGameObject = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Prefabs/SpikeStrip 1"));

            HealthBar healthBar = healthBarGameObject.GetComponent<HealthBar>();

            SpikeDMG spike = car.GetComponent<SpikeDMG>();
            spike.health = healthBar;

            float initialHealth = 100.0f;

            car.transform.position = new Vector3(0, 0, 0);
            spikeStripGameObject.transform.position = new Vector3(0, 0, 0);

            //wait 3 seconds
            yield return new WaitForSeconds(3f);
            
            Debug.Log("Car current health: " + healthBar.currenthealth);

            //check currenttime not null
            Assert.Less(healthBar.currenthealth, initialHealth);
        }

    }
}
