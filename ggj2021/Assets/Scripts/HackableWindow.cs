using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackableWindow : MonoBehaviour
{
    public PlayerController controller;
    public GameObject mySelf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        //isenabled
    }

    public void turnOff(){
        controller.uiOff();
        mySelf.SetActive(false);
    }

    public void launchHack(int pu){
        Hackable hobj = (Hackable) controller.getFocus();
        hobj.hack((PlayerController.Powerups) pu, controller);
    }
}
