using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullSreenToggleScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Set the initial fullscreen state to false
        Screen.fullScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for the F11 keypress to toggle fullscreen
        if (Input.GetKeyDown(KeyCode.F11))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}

