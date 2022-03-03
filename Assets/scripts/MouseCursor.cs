using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }

    }
}
