using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerController;

public class HackableStatus : MonoBehaviour
{
    public GameObject windowsHack;

    public GameObject mySelf;

    public GameObject[] status;

    public Button close1;
    public Button close2;

    public PlayerController controller;

    private Hackable hobj;

    void OnEnable(){
        hobj = (Hackable) controller.getFocus();

        // setup status
        if (hobj.first_slot != (Powerups.None, SubPowerups.None)){
            status[0].GetComponent<statusManagement>().setNames((hobj.first_slot));
        } else {
            status[0].SetActive(false);
        }
        
        if (hobj.second_slot != (Powerups.None, SubPowerups.None)){
            status[1].GetComponent<statusManagement>().setNames((hobj.second_slot));
        } else {
            status[1].SetActive(false);
        }

    }

    void Start(){
        Debug.Log("HackableStatus ready");
        close1.onClick.AddListener(()=>{
            Powerups mainpow = hobj.first_slot.Item1;
            SubPowerups secpow = hobj.first_slot.Item2;

            hobj.first_slot = (Powerups.None, SubPowerups.None);
            status[0].SetActive(false);

            hobj.looseHack((mainpow,secpow), controller);
            returnToPlayer((mainpow,secpow));
        });

        close2.onClick.AddListener(()=>{
            Powerups mainpow = hobj.second_slot.Item1;
            SubPowerups secpow = hobj.second_slot.Item2;

            hobj.second_slot = (Powerups.None, SubPowerups.None);
            status[1].SetActive(false);

            hobj.looseHack((mainpow,secpow), controller);
            returnToPlayer((mainpow,secpow));
        });
    }

    private void returnToPlayer((Powerups,SubPowerups) functions){
        controller.addPowerup(functions.Item1);
        if(functions.Item2 != SubPowerups.None){
            controller.addSubPowerup(functions.Item2);
        }
    }

    public void allturnOff(){
        controller.uiOff();
        mySelf.SetActive(false);
        windowsHack.SetActive(false);
    }

    public void addFct(){
        windowsHack.SetActive(true);
    }
}
