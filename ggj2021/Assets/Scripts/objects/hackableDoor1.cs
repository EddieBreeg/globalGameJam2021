using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackableDoor1 : Hackable
{
    public AudioClip soundNull;
    public AudioSource source;

    bool active;

    public override void hack(PlayerController.Powerups pu, PlayerController controller){
        powerups[(int)pu] = true;

        switch (pu)
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
