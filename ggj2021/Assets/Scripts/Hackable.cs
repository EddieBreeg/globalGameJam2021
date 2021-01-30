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

    void Start(){
        powerups = new bool[Globally.nbPowerups];
        subpowerups = new bool[Globally.nbSubpowerups];
    }

    public override void interact(PlayerController controller){
        //launch ui
        windowObject.SetActive(true);
        controller.uiOn();
    }   

}