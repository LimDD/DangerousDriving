using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMainMenu : MonoBehaviour
{
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>(); // Get the button linked to the gameobject
        button.onClick.AddListener(onClick); // Add button listener
    }

    void onClick()
    {
        SceneManager.LoadScene(0); // Index 0 = Main menu
    }
}
