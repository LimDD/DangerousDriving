using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> models;
    private int selectionIndex = 0;
    void Start()
    {
        selectionIndex = PlayerPrefs.GetInt("CarSelected");
        models = new List<GameObject>();
        foreach(Transform t in transform)
        {
            models.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }
        models[selectionIndex].SetActive(true);
    }

    private void Update()
    {
        //transform.Rotate(new Vector3(0.0f, Input.GetAxis("Mouse X")));
       
    }

    public void Select(int index)
    {
        if (index == selectionIndex)
            return;

        if (index < 0 || index >= models.Count)
            return;

        models[selectionIndex].SetActive(false);
        selectionIndex = index;
        models[selectionIndex].SetActive(true);
    }
    
    public void ConfirmCar()
    {
        PlayerPrefs.SetInt("CarSelected", selectionIndex);
        SceneManager.LoadScene(1);
    }

    public void Left()
    {
        models[selectionIndex].SetActive(false);
        selectionIndex = selectionIndex - 1;
        if (selectionIndex < 0)
        {
            selectionIndex = 4;
        }
        models[selectionIndex].SetActive(true);
    }

    public void Right()
    {
        models[selectionIndex].SetActive(false);
        selectionIndex = selectionIndex + 1;
        if (selectionIndex == 5)
        {
            selectionIndex = 0;
        }
        models[selectionIndex].SetActive(true);
    }
}
