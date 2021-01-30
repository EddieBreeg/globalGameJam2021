using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static PlayerController;

public class TestHackable : Hackable
{
    //TODO : change function signature (+ arg PlayerController.SubPowerups)
    public override void hack((Powerups,SubPowerups) functions, PlayerController controller){
        if(functions == (Powerups.Activate,SubPowerups.None)){
            Debug.Log("Activate");
        }
        else if((Powerups.Open,SubPowerups.None) == functions){
            Debug.Log("Open");
        }
        else{
            //default
        }
    }
}
