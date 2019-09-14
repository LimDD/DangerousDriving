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
            LapTimer ltscript = car.GetComponent<LapTimer>();

            gamestarted = ltscript.getstartflag;

            yield return null;
            if (gamestarted == false)
            {
                string timevalue = ltscript.getcurrenttime;
                Assert.IsNull(timevalue);
            }
        }
    }
}
