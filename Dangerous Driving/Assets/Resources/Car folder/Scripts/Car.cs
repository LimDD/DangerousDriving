using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Car speed and steering
    [SerializeField] float accelerate = 100f;
    [SerializeField] float steer = 50f;

    // Car sounds
    [SerializeField] AudioClip mainEngine;
    [SerializeField] AudioClip death;

    // Car particles
    [SerializeField] ParticleSystem wheelParticles;
    [SerializeField] ParticleSystem deathParticles;
    [SerializeField] ParticleSystem completeLapParticles;

    // Car attributes
    Rigidbody carBody;
    AudioSource audioSource;
    bool isTranscending = false;

    // Start is called before the first frame update
    void Start()
    {
        carBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void RespondToAccelerateInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ApplyAcceleration();
        }
        else
        {
            audioSource.Stop();
            //TODO:  Particles stop
        }
    }

    private void RespondToSteerInput()
    {
        

        // Left Steer
        if (Input.GetKey(KeyCode.A))
        {
            //carBody.freezeRotation = true; // manual control

            float steerThisFrame = steer * Time.deltaTime;

            transform.Rotate(Vector3.down * steerThisFrame);
            //carBody.freezeRotation = false; // physics control
        }
        // Right Steer
        else if (Input.GetKey(KeyCode.D))
        {
            //carBody.freezeRotation = true; // manual control
            float steerThisFrame = steer * Time.deltaTime;

            transform.Rotate(Vector3.up * steerThisFrame);
            //carBody.freezeRotation = false; // physics control
        }
        

        
    }

    private void RespondToCameraInput()
    {
        if (Input.GetKey(KeyCode.R))
        {

        }

    }

    private void ApplyAcceleration()
    {
        carBody.AddRelativeForce(Vector3.forward * accelerate * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        RespondToAccelerateInput();
        RespondToSteerInput();
    }
}
