using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Load Scenes
public class SceneScript : MonoBehaviour
{
    public void DriftScene()
    {
        SceneManager.LoadScene("Drift Track");
    }
}
