using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hackable : Interactable
{
    public bool[] powerups;
    abstract public void hack(PlayerController.Powerups pu, PlayerController controller);

}