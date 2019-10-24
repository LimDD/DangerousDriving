using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    [SerializeField] Material CurrMat;
    [SerializeField] Renderer renderer;
    private int colourIndex = 0;
    // Use this for initialization
    void Start()
    {
     
        renderer = this.GetComponent<Renderer>();
        colourIndex = PlayerPrefs.GetInt("ColourSelected");
        renderer.material = BodyColorMat[colourIndex];
        CurrMat = renderer.material;


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BlueColor()
    {
        colourIndex = 0;
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColourSelected", colourIndex);
    }


    public void GreenColor()
    {
        colourIndex = 1;
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColourSelected", colourIndex);
    }


    public void redColor()
    {
        colourIndex = 2;
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColourSelected", colourIndex);
    }



}