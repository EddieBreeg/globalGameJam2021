using System.Collections;
using System.Collections.Generic;
using System;
using static PlayerController;
using static Globally;
using UnityEngine;

public abstract class Hackable : Interactable
{
    public GameObject windowStatus;

    public (Powerups, SubPowerups) first_slot;
    public (Powerups, SubPowerups) second_slot;
    abstract public void hack((Powerups,SubPowerups) functions, PlayerController controller);
    abstract public void looseHack((Powerups,SubPowerups) functions, PlayerController controller);

    void Start(){

    }

    protected void initialize(){
        first_slot = (Powerups.None,SubPowerups.None);
        second_slot = (Powerups.None,SubPowerups.None);
    }

    public override void interact(){
        //launch hack window
        windowStatus.SetActive(true);
        Globally.getPlayer().uiOn();
    }   

}