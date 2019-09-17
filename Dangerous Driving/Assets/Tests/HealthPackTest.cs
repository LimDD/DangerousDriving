using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    
    [TestFixture]
    public class HealthPackTest
    {
        private HealthBar bar;

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator HealthPackTestWithEnumeratorPasses()
        {
            GameObject healthPackObject = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Pickups/FirstAid"));
            GameObject car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));
            GameObject healthBar = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("export/HealthBar"));
            FirstAid firstAid;
            int initialHealth;

            // Get the FirstAid object from car
            firstAid = car.GetComponent<FirstAid>();
            

            // Get the health bar
            bar = healthBar.GetComponent<HealthBar>();
            bar.currenthealth = 50;
            firstAid.hb = bar;

            // Set the initial health
            initialHealth =(int)bar.currenthealth;
            Debug.Log(bar.currenthealth);
            car.transform.position = healthPackObject.transform.position;
            //healthPack.transform.position = new Vector3(50, 50, 50);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(1f);
            
            
            Debug.Log(bar.currenthealth);

            Assert.Greater(bar.currenthealth, initialHealth);
        }
    }
}
