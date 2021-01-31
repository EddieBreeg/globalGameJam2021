using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ChangeScene;

public class YesButton : MonoBehaviour
{
    
    public Memory memory;
    Button yesBut;

    public AudioSource audioSource;
    public AudioClip corrupted_sound;
    public AudioClip success_sound;
    public GameObject memWindow;

    // Start is called before the first frame update
    void Start()
    {
        yesBut = GetComponent<Button>();
        yesBut.onClick.AddListener(()=>{
            if(memory.isCorrupted()){
                //on joue un son cursed
                audioSource.PlayOneShot(corrupted_sound);
                //on reset le niveau
                ChangeScene.resetScene();
            } else {
                //on joue un son sympathique
                audioSource.PlayOneShot(success_sound);
                //on ramasse le memory
                memory.gatherMemory();
            }
            
            //on close la window
            Globally.getPlayer().uiOff();
            memWindow.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
