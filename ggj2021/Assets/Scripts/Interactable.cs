using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour{

    private void OnTriggerEnter(Collider collision){
        Debug.Log("Entering zone");
        if (collision.gameObject.tag == "Player"){
            PlayerController control = collision.gameObject.GetComponent<PlayerController>();
            control.setFocus(this);
        }
    }

    private void OnTriggerExit(Collider collision){
        if(collision.gameObject.tag == "Player"){
            PlayerController control = collision.gameObject.GetComponent<PlayerController>();
            control.setFocus(null);
        }
    }

    public abstract void interact();
}