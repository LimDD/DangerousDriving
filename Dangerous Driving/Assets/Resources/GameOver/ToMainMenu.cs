﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    public void changescene()
    {
        SceneManager.LoadScene(0);
    }
}