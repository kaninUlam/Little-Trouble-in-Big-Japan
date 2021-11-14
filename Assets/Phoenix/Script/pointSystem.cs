using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class pointSystem: MonoBehaviour
{
    [SerializeField] public int _playerScore;
    [SerializeField] private TMP_Text _scoreText;
    public Text ScoreText;

    private void Start()
    {
        _playerScore = 5000;
    }

    public void UpdateScore(int points)
    {
        //update UI Score
        _playerScore += points;
        
    }

    void Update()
    {
        ScoreText.text = "Score: " + _playerScore;
    }
}
