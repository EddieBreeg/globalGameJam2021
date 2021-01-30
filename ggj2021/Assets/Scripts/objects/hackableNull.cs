using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackableNull : Hackable
{
    public AudioClip soundNull;
    public AudioSource source;

    public  override void hack(PlayerController.Powerups pu, PlayerController controller){
        switch (pu){
            default:
                source.clip = soundNull;
                source.Play();
                break;
        }

    }
}
