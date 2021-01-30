using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static PlayerController;
using TMPro;

public class HackableWindow : MonoBehaviour
{
    public PlayerController controller;
    public GameObject mySelf;

    public Button apply;

    // Start is called before the first frame update
    void Start()
    {
        apply.onClick.AddListener(()=>{
            //get values of functions
            //apply hacks
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        //change possibilities
        
    }

    public void turnOff(){
        //controller.uiOff();
        mySelf.SetActive(false);
    }

    public void launchHack(int pu){
        Hackable hobj = (Hackable) controller.getFocus();
        hobj.hack(((PlayerController.Powerups) pu, PlayerController.SubPowerups.None), controller);
    }
}
