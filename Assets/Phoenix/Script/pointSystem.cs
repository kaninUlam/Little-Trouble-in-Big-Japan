using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class pointSystem: MonoBehaviour
{
    [SerializeField] public int _playerScore = 0;
    [SerializeField] public int _scoreText = 0;

    public static pointSystem Instance;

    public Text ScoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //_playerScore = 5000;
        //ScoreText.text = ScoreText.ToString() + " Points";
    }

    public void UpdateScore(float amount)
    {
        //_scoreText += 1;
        _playerScore += (int)amount;
        //ScoreText.text = ScoreText.ToString() + " Points";
    }

    void Update()
    {
        ScoreText.text = "Score: " + _playerScore;
    }
}
