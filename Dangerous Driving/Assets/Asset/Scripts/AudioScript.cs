﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource;
    void Start()
    {
        MusicSource = GetComponent<AudioSource>();
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MusicSource.Play();
        }
    }
}