using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHackable : Hackable
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void hack(PlayerController.Powerups pu, PlayerController controller){
        switch (pu)
        {
            case PlayerController.Powerups.Activate:
                //do something
                break;
            case PlayerController.Powerups.Open:
                //do something
                break;
            default:
                //do something
                break;
        }
    }

    public override void interact(PlayerController controller){
        //todo
    }   
}
