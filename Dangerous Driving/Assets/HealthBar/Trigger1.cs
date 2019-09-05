using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger1 : MonoBehaviour
{
    public int IsTriggered;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            IsTriggered = 1; //true
        }

        if (other.CompareTag("Finish"))
        {
            if (IsTriggered == 1) //trigger has been triggered
            {
                SceneManager.LoadScene(2); //index2 = 'GameOver' scene
            }

        }
    }

    public int GetTrigger
    {
        get { return IsTriggered; }
    }

    // Start is called before the first frame update
    void Start()
    {
        IsTriggered = 0; //false
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
