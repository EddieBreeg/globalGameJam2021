using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ChangeScene;
using UnityEngine.UI;

public class LaunchButton : MonoBehaviour
{

    private Button launch;
    // Start is called before the first frame update
    void Start()
    {   
        launch = GetComponent<Button>();
        launch.onClick.AddListener(() => ChangeScene.changeScene("Scenes/Tests"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
