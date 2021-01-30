using System.Collections;
using System.Collections.Generic;
using System;
using static PlayerController;
using UnityEngine;

public abstract class Hackable : Interactable
{
    public GameObject windowObject;

    public bool[] powerups;
    public bool[] subpowerups;
    abstract public void hack((Powerups,SubPowerups) functions, PlayerController controller);
    abstract public void looseHack((Powerups,SubPowerups) functions, PlayerController controller);


    public bool hasPowerup(Powerups pu){
        return powerups[(int)pu];
    }

    public void removePowerup(Powerups pu){
        powerups[(int)pu] = false;
    }

    public void addPowerup(Powerups pu){
        powerups[(int)pu] = true;
    }

    public bool hasSubPowerup(SubPowerups spu){
        return subpowerups[(int)spu];
    }

    public void removeSubPowerup(SubPowerups spu){
        subpowerups[(int)spu] = false;
    }

    public void addSubPowerup(SubPowerups spu){
        subpowerups[(int)spu] = true;
    }

    void Start(){
        powerups = new bool[Globally.nbPowerups];
        subpowerups = new bool[Globally.nbSubpowerups];
    }

    public override void interact(PlayerController controller){
        //launch hack window
        windowObject.SetActive(true);
        controller.uiOn();
    }   

}