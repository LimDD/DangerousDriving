using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Test3
    {
        GameObject Astriod;
        GameObject Car;
        GameObject Health;
        
        HealthBar healthBar;
        ShockwaveCollider shockwave;
        float initialHealth;
        // A Test behaves as an ordinary method
        [Test]
        public void Test3SimplePasses()
        {
            //Objects that will be tested.
            Astriod = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("AsteroidPack/PAsteroid"));
            Car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));
            Health = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Scripts/HealthBar"));

            healthBar = Health.GetComponent<HealthBar>();
            initialHealth = 100;
            shockwave = Car.GetComponent<ShockwaveCollider>();
            shockwave.hb = healthBar;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Test3WithEnumeratorPasses()
        {
            Car.transform.position = new Vector3(0, 0, 0);
            Astriod.transform.position = new Vector3(0, 0, 0);

            yield return new WaitForSeconds(5);

            Debug.Log("Car initial health: " + initialHealth);
            Debug.Log("Car health: " + healthBar.currenthealth);
            Assert.Less(healthBar.currenthealth, initialHealth);
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            
        }
    }
}
