using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityStandardAssets.Vehicles.Car;

namespace Tests
{
    public class CarSpikeSlowTest
    {
        GameObject car;
        CarController carController;
        float speed;
        // A Test behaves as an ordinary method
        [Test]
        public void CarSpikeSlowTestSimplePasses()
        {
            car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));
            carController = car.GetComponent<CarController>();
            car.GetComponent<StartFinish>().enabled = false; // Disable the start finish script
            speed = carController.m_Topspeed;
            
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CarSpikeSlowTestWithEnumeratorPasses()
        {
            GameObject spike = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Obstacles/SpikeStripPrefab"));
            GameObject healthBar = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Scripts/HealthBar"));
            HealthBar health = healthBar.GetComponent<HealthBar>();
            SpikeDMG spikeComponent = car.GetComponent<SpikeDMG>();
            spikeComponent.health = health;
            spike.transform.position = new Vector3(0,0,0);
            car.transform.position = new Vector3(0,0,0);
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(1f);
            Assert.Less(carController.m_Topspeed, speed);
        }
    }
}
