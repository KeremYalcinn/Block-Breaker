using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    bool isPaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isPaused)
            {
                Cursor.visible = false;
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Cursor.visible = true;
                Time.timeScale = 0;
                isPaused = true;
            }
        }

    }
}
