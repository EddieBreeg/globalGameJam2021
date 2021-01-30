using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ChangeScene;

public class ExitButton : MonoBehaviour
{

    private Button exit;

    // Start is called before the first frame update
    void Start()
    {
        exit = GetComponent<Button>();
        exit.onClick.AddListener(() => ChangeScene.exit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
