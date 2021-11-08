using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class pointSystem: MonoBehaviour
{
    [SerializeField] private int _playerScore;
    [SerializeField] private TMP_Text _scoreText;

    private void Start()
    {
        _playerScore = 0;
    }

    public void UpdateScore(int points)
    {
        //update UI Score
        _playerScore += points;
        _scoreText.text = "Score: " + _playerScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
