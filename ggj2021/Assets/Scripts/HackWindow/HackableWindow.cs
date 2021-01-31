using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static PlayerController;
using TMPro;

public class HackableWindow : MonoBehaviour
{
    PlayerController controller;
    public GameObject mySelf;
    public HackableStatus mainWin;

    public ToggleGroup mainfct;
    public ToggleGroup secondefct;
    public Button apply;

    public Toggle tog_Activate;
    public Toggle tog_Open;

    public Toggle tog_Timeout;

    public Toggle tog_Repeat;

    // Start is called before the first frame update

    void initialize(){
        mainfct.SetAllTogglesOff();
        secondefct.SetAllTogglesOff();
        controller = Globally.getPlayer();

        tog_Activate.enabled = false;
        tog_Open.enabled = false;
        tog_Timeout.enabled = false;
        tog_Repeat.enabled = false;
    
    }

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        //change possibilities
        initialize(); // warning: issue

        if(controller.hasPowerup(Powerups.Activate))
            tog_Activate.enabled = true;
        if(controller.hasPowerup(Powerups.Open))
            tog_Open.enabled = true;
        if(controller.hasSubPowerup(SubPowerups.Repeat))
            tog_Repeat.enabled = true;
        if(controller.hasSubPowerup(SubPowerups.Timeout))
            tog_Timeout.enabled = true;
    }

    public void turnOff(){
        //controller.uiOff();
        mySelf.SetActive(false);
    }

    public void launchHack(int pu){
        mainfct.EnsureValidState(); // not sure it is useful

        Hackable hobj = (Hackable) controller.getFocus();
        PlayerController.SubPowerups secondefct_enum = PlayerController.SubPowerups.None;
        PlayerController.Powerups mainfct_enum = PlayerController.Powerups.None;

        if(tog_Activate.isOn)
            mainfct_enum = Powerups.Activate;
        if(tog_Open.isOn)
            mainfct_enum = Powerups.Open;

        if(tog_Timeout.isOn)
            secondefct_enum = SubPowerups.Timeout;
        if(tog_Repeat.isOn)
            secondefct_enum = SubPowerups.Repeat;    
        
        hobj.hack((mainfct_enum, secondefct_enum), controller);

        mainWin.updateInfos();
        mySelf.SetActive(false);
    }
}
