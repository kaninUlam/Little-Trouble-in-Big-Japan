using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class DifferentPointSystem: MonoBehaviour
{
    [SerializeField] public int _PlayerScore = 0;
    [SerializeField] public int _scoreText = 0;

    public static DifferentPointSystem Points;
    public TextMeshProUGUI CurrentScoreText;

    private void Awake()
    {
        Points = this;
    }

    private void Start()
    {
        //_playerScore = 5000;
        //ScoreText.text = ScoreText.ToString() + " Points";
    }

    public void UpdateScore(float amount)
    {
        //_scoreText += 1;
        _PlayerScore += (int)amount;
        //ScoreText.text = ScoreText.ToString() + " Points";
    }

    void Update()
    {
        CurrentScoreText.text = "Score: " + _PlayerScore;
    }
}
