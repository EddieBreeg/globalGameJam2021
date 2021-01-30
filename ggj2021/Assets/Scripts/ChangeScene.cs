using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool playerPresent = false;

    static public void changeScene(string scenePath){
        SceneManager.LoadScene(scenePath);
    }

    static public void resetScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    static public void exit(){
        Application.Quit();
    }

    public void OnTriggerEnter(Collider collide){
        Debug.Log("scene changed entered");
        Debug.Log(playerPresent);
        if(collide.gameObject.tag == "Player"){
            playerPresent = true;
        }
    }

    public void OnTriggerExit(Collider collide){
        Debug.Log("scene changed exited");
        Debug.Log(playerPresent);
        if(collide.gameObject.tag == "Player"){
            playerPresent = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
