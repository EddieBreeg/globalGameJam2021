using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static PlayerController;

public class hackableDoor1 : Hackable
{
    public AudioClip soundNull;
    public AudioSource source;

    bool active;

    public override void hack((Powerups,SubPowerups) functions, PlayerController controller){
        powerups[(int)functions.Item1] = true;

        switch (functions.Item1)
        {
            case PlayerController.Powerups.Activate:
                //do something
                Debug.Log("Activate");
                active = true;
                break;
            case PlayerController.Powerups.Open:
                //do something
                if (active){
                    Debug.Log("Open");
                }
                 break;
            default:
                //do something
                break;
        }
    }
}
