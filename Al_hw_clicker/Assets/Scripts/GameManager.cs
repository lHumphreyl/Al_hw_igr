using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;

    private int score = 0;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        Instance.AddScore(0);
    }

    public void AddScore(int value)
    {
        score += value;
        ScoreText.text = "Score: " + score.ToString();
    }
}
