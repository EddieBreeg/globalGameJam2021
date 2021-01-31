using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPUPickup : Interactable
{

    //should be < to powerup inventory size
    public PlayerController.SubPowerups SUBPOWERUP;

    public GameObject mySelf;
    public AudioSource source;
    public AudioClip pickupSound;


    public override void interact(){
        Globally.getPlayer().addSubPowerup(SUBPOWERUP);
        Globally.getPlayer().setFocus(null);

        source.clip = pickupSound;
        source.Play();
        //se desactive
        mySelf.SetActive(false);
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
