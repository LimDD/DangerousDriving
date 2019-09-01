using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] Camera birdsEyeCamera;
    [SerializeField] Camera thirdPersonCamera;

    AudioListener birdsEyeCameraAudio;
    AudioListener thirdPersonCameraAudio;

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        // Get the audio listeners from each camera
        birdsEyeCameraAudio = birdsEyeCamera.GetComponent<AudioListener>();
        thirdPersonCameraAudio = thirdPersonCamera.GetComponent<AudioListener>();
        counter = 0;

        // To be changed
        // Start the game on birds eye view
        birdsEyeCamera.enabled = true;
        birdsEyeCameraAudio.enabled = true;
        birdsEyeCamera.tag = "MainCamera"; // Set the tag to MainCamera

        thirdPersonCamera.enabled = false;
        thirdPersonCameraAudio.enabled = false;
        thirdPersonCamera.tag = "Untagged";
    }

    // Update is called once per frame
    void Update()
    {
        CheckCameraUserInput();
    }

    private void CheckCameraUserInput()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCounter();
        }
    }

    private void SwitchCounter()
    {
        if (counter == 0)
        {
            SwitchToThirdPersonCamera();
            counter = 1;
        }
        else
        {
            SwitchToBirdsEyeCamera();
            counter = 0;
        }
    }

    private void SwitchToBirdsEyeCamera()
    {
        thirdPersonCamera.enabled = false;
        thirdPersonCameraAudio.enabled = false;
        thirdPersonCamera.tag = "Untagged";

        birdsEyeCamera.enabled = true;
        birdsEyeCameraAudio.enabled = true;
        birdsEyeCamera.tag = "MainCamera"; // Set the tag to MainCamera
    }

    private void SwitchToThirdPersonCamera()
    {
        birdsEyeCamera.enabled = false;
        birdsEyeCameraAudio.enabled = false;
        birdsEyeCamera.tag = "Untagged";

        thirdPersonCamera.enabled = true;
        thirdPersonCameraAudio.enabled = true;
        thirdPersonCamera.tag = "MainCamera";
    }
}
