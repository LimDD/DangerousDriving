using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    [SerializeField] Material CurrMat;
    [SerializeField] Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BlueColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }


    public void GreenColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }


    public void redColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }



}