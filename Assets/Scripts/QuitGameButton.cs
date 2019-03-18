using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Application Quit");
            Application.Quit();
        }
    }
}
