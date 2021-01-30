using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHackable : Hackable
{
    public override void hack(PlayerController.Powerups pu, PlayerController controller){
        switch (pu)
        {
            case PlayerController.Powerups.Activate:
                //do something
                Debug.Log("Activate");
                break;
            case PlayerController.Powerups.Open:
                //do something
                Debug.Log("Open");
                break;
            default:
                //do something
                break;
        }
    }
}
