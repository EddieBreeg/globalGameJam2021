using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static PlayerController;
using static Globally;

public class statusManagement : MonoBehaviour
{
    public TMP_Text fct1;
    public TMP_Text fct2;

    public void setNames((Powerups, SubPowerups) powers){
        fct1.text = (powers.Item1 == Powerups.Activate) ? Globally.fn_name_activate : Globally.fn_name_open;
      
        if(powers.Item2 != SubPowerups.None){
            fct2.text = (powers.Item2 == SubPowerups.Repeat) ? Globally.sub_fn_name_repeat : Globally.sub_fn_name_timeout;
        } else {
            fct2.text = "";
        }
    }
}
