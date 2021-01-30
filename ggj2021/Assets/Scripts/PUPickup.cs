using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPickup : MonoBehaviour
{

    //should be < to powerup inventory size
    public PlayerController.Powerups POWERUP;

    private void OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Player"){
            givePowerup(collision.gameObject);
            
        }
    }

    private void givePowerup(GameObject player){
        PlayerController control = player.GetComponent<PlayerController>();
        control.addPowerup(POWERUP);
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
