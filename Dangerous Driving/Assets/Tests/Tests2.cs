using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests2
    {
        public bool gamestarted;
        // A Test behaves as an ordinary method
        [Test]
        public void Tests2SimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Tests2WithEnumeratorPasses()
        {
            //instantiate laptimber object
            GameObject laptimer = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Prefabs/LapTimer"));

            //instantiate car object
            GameObject car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));

            //reference LapTimer script
            LapTimer ltscript = car.GetComponent<LapTimer>();

            //check if game has started
            gamestarted = ltscript.getstartflag;

            yield return null;

            //game started == false → game not started
            if (gamestarted == false) 
            {
                string timevalue = ltscript.getcurrenttime; //game not started → timevalue of timer = null
                Assert.IsNull(timevalue); //verify timevalue is null
            }
        }
    }
}
