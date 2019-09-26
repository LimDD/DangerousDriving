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

    }
}
