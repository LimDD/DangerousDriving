using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class LoadDriftTrackTest
    {
        Scene driftTrack;
        int index;
        // A Test behaves as an ordinary method
        [Test]
        public void LoadDriftTrackTestSimplePasses()
        {
            // Use the Assert class to test conditions
            driftTrack = SceneManager.GetActiveScene(); // Get current scene
            index = driftTrack.buildIndex; // Get the current build index
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator LoadDriftTrackTestWithEnumeratorPasses()
        {
            SceneManager.LoadScene(1);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(2f);
            driftTrack = SceneManager.GetActiveScene(); // get loaded scene
            index = driftTrack.buildIndex;

            Assert.AreEqual(1, index);
        }
    }
}
