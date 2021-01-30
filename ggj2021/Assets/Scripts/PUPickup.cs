using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPickup : Interactable
{

    //should be < to powerup inventory size
    public PlayerController.Powerups POWERUP;



    public override void interact(PlayerController player){
        player.addPowerup(POWERUP);
        player.setFocus(null);
        //se desactive
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
