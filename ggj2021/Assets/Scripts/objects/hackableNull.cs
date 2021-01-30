using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerController;
using System;

public class hackableNull : Hackable
{
    public AudioClip soundNull;
    public AudioSource source;

    public  override void hack((Powerups,SubPowerups) functions, PlayerController controller){
        switch (functions.Item1){
            default:
                source.clip = soundNull;
                source.Play();
                break;
        }

    }
}
