using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class NewTestScript
    {
        InputField inputfield;

        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            SetupScene();
            yield return new WaitForSeconds(1);

            inputfield = GameObject.Find("LapTimerText(Clone").GetComponent<InputField>();
            Debug.Log(inputfield.text);

            Assert.IsNull(inputfield);
        }

        void SetupScene()
        {
            MonoBehaviour.Instantiate(Resources.Load<GameObject>("Canvas"));
            MonoBehaviour.Instantiate(Resources.Load<GameObject>("LapTimerText"));
        }
    }
}
