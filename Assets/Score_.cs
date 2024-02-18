using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private int score;
    private static ScoreManager instance;

    private void Start()
    {
        instance = this;
        score = 0;
        UpdateScoreUI();
    }
  

    public static void AddScore(int points)
    {
        instance.score += points;
        UpdateScoreUI();
 
    }

    private static void UpdateScoreUI()
    {
        instance.scoreText.text = "Score: " + instance.score.ToString();
    }
}