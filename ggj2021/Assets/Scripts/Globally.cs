using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//variables globales

public static class Globally{
    public const int nbSubpowerups = 2;
    public const int nbPowerups = 2;

    public const string fn_name_activate = "Activer";
    public const string fn_name_open = "Ouvrir";

    public const string sub_fn_name_repeat = "Répeter";
    public const string sub_fn_name_timeout = "Expiration";

    public static PlayerController getPlayer(){
        return GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
}