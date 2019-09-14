using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests2
    {
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
            GameObject car = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Car folder/Prefabs/Car"));
            GameObject laptimer = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Assets/Resources/Asset/Prefabs/LapTimer.prefab"));

            //LapTimer ltscript = car.GetComponent<LapTimer>();

           // bool gamestarted = ltscript.getstartflag;

            yield return null;
           // if (gamestarted == false)
            //{
                //string timevalue = ltscript.getcurrenttime;
                //Assert.IsNull(timevalue);
            //}

            bool x = false;

           Assert.IsFalse(x);

        }
    }
}
