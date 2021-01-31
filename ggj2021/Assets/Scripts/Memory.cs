using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : Interactable
{
    public GameObject windowMemory;
    public GameObject mySelf;
    public AudioSource source;
    public AudioClip activateSound;

    public bool corrupted;

    public override void interact(){
        Globally.getPlayer().setFocus(null);
        Globally.getPlayer().uiOn();
        windowMemory.SetActive(true);
        source.clip = activateSound;
        source.Play();
    }

    public void gatherMemory(){
        mySelf.SetActive(false);
        Globally.getPlayer().uiOn();
        Globally.getPlayer().gatherMemory();
    }

    public bool isCorrupted(){
        return corrupted;
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
