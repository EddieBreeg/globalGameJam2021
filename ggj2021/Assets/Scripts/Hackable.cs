using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hackable : Interactable
{
    public GameObject windowObject;

    public bool[] powerups;
    abstract public void hack(PlayerController.Powerups pu, PlayerController controller);

    void Start(){
        powerups = new bool[Globally.nbPowerups];
    }

    public override void interact(PlayerController controller){
        //launch ui
        windowObject.SetActive(true);
        controller.uiOn();
    }   

}