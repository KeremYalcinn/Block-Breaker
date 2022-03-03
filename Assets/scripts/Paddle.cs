using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;
    void Update()
    {
        if (Time.timeScale == 1) 
        {
            float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
            Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
            paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
            transform.position = paddlePos;
        }
    }
}
