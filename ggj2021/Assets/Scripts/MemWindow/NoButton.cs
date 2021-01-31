using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : MonoBehaviour
{
    Button nobutton;
    public GameObject memoryWindow;

    // Start is called before the first frame update
    void Start()
    {
        nobutton = GetComponent<Button>();
        nobutton.onClick.AddListener(()=>{
            //on close la window
            memoryWindow.SetActive(false);
            Globally.getPlayer().uiOff();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
