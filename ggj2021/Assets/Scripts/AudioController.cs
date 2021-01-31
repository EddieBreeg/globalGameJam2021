using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = audioClipArray[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(! audioSource.isPlaying){
            audioSource.loop = true;
            audioSource.clip = audioClipArray[1];
            audioSource.Play();

        }
    }
}
