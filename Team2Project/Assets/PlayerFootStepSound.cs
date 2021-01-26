﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootStepSound : MonoBehaviour
{

    private AudioSource footstep_Sound;

    [SerializeField]
    private AudioClip[] footstep_Clip;

    private CharacterController character_Controller;

    public float volume_Min, volume_Max;

    private float accumulated_Distance;

    public float step_Distance;
    // Start is called before the first frame update
    void Awake()
    {
        footstep_Sound = GetComponent<AudioSource>();

        character_Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckToPlayFootStepSound();
    }

    void CheckToPlayFootStepSound()
    {
        if (!character_Controller.isGrounded)
            return;

        if (character_Controller.velocity.sqrMagnitude > 0)
        {
            accumulated_Distance += Time.deltaTime;

            if (accumulated_Distance > step_Distance)
            {
                footstep_Sound.volume = Random.Range(volume_Min, volume_Max);
                footstep_Sound.clip = footstep_Clip[Random.Range(0, footstep_Clip.Length)];
                footstep_Sound.Play();

                accumulated_Distance = 0f;

            }
        }
        else 
        {
            accumulated_Distance = 0f;}
    }
}