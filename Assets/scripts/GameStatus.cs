using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [SerializeField] int pointsPerBlockDestroyed = 127;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int currentScore = 0;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
        Cursor.visible = false;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
