using System.Collections;
using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests2
    {
        [UnityTest]
        public IEnumerator LapTimerStarts()
        {
            //instantiate laptimber object
            GameObject laptimer = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Prefabs/LapTimer"));

            //reference LapTimer script
            LapTimer ltscript = laptimer.GetComponent<LapTimer>();

            //start lap timer
            ltscript.startTimer = 1;

            //wait 3 seconds
            yield return new WaitForSeconds(3f);

            //get currentime
            string timevalue = ltscript.getcurrenttime;

            //check currenttime not null
            Assert.IsNotNull(timevalue);
        }

        [UnityTest]
        public IEnumerator LapTimerStops()
        {
            //instantiate laptimber object
            GameObject laptimer = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Prefabs/LapTimer"));

            //reference LapTimer script
            LapTimer ltscript = laptimer.GetComponent<LapTimer>();

            //start lap timer
            ltscript.startTimer = 1;

            //wait 3 seconds
            yield return new WaitForSeconds(3f);

            //stop timer
            ltscript.startTimer = 0;

            //get currenttime now timer has stopped
            string timevalue1 = ltscript.getcurrenttime;

            //wait 3 seconds
            yield return new WaitForSeconds(3f);

            //get current time again
            string timevalue2 = ltscript.getcurrenttime;

            //check timer has stopped
            Assert.AreEqual(timevalue1, timevalue2);

            //show that timevalues are not null i.e timer started and then stopped
            Assert.IsNotNull(timevalue1);
            Assert.IsNotNull(timevalue2);
        }

        [UnityTest]
        public IEnumerator LapTimerAccuracy()
        {
            //instantiate laptimber object
            GameObject laptimer = MonoBehaviour.Instantiate<GameObject>(Resources.Load<GameObject>("Asset/Prefabs/LapTimer"));

            //reference LapTimer script
            LapTimer ltscript = laptimer.GetComponent<LapTimer>();

            //start lap timer
            ltscript.startTimer = 1;

            //wait 3 seconds
            yield return new WaitForSeconds(3f);

            //stop timer
            ltscript.startTimer = 0;

            //get currenttime now timer has stopped
            string timevalue = ltscript.getcurrenttime;

            char c = timevalue[6];
            int x = Convert.ToInt32(new string(c, 1));

            //check that timer seconds value is greater than 2
            Assert.Greater(c, 2);
        }
    }
}
