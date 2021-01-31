using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static PlayerController;

public class hackableDoor : Hackable
{
    public AudioClip soundNull;
    public GameObject door;
    public AudioSource source;

    Transform tr;
    
    bool active;
    bool opening;
    bool closing;

    Vector3 upPoint;
    float epsilon;

    public int speed;
    public Vector3 openingHeight = new Vector3(0,20,0);

    void Start(){
        initialize();

        opening = false;
        tr = door.GetComponent<Transform>();
        upPoint = tr.position + openingHeight; 
        epsilon = 1f;
    }

    public override void hack((Powerups,SubPowerups) functions, PlayerController controller){        
        if(first_slot != (Powerups.None, SubPowerups.None)){
            second_slot = functions;
        } else {
            first_slot = functions;
        }
        controller.removePowerup(functions.Item1);

        if(functions.Item1 == Powerups.Activate){
            active = true;
        } else if(functions.Item1 == Powerups.Open){
            if(active){
                opening = true;
            }
        } else {
            //default
        }
    }

    public override void looseHack((Powerups,SubPowerups) functions, PlayerController controller){
        if(functions.Item1 == Powerups.Activate){
            active = false;
        } else if(functions.Item1 == Powerups.Open) {
            if(active){
                opening = false;
                closing = true;
            }
        } else {
            //Default
        }
    }

    void Update(){
        if(active && opening){
            tr.position += Vector3.up * Time.deltaTime * speed;
            float y = tr.position.y - upPoint.y;
            if(Math.Abs(y) < epsilon){
                opening = false;
            }
        }
        if(active && closing){
            tr.position -= Vector3.up * Time.deltaTime * speed;
            float y = tr.position.y;
            if(Math.Abs(y) < epsilon){
                closing = false;
            }
        }
    }
}
