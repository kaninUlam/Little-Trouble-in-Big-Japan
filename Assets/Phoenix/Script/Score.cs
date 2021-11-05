using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0;

    [SerializeField] Text scoreAmount;

    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
    }

    public void AddScore(float amount)
    {
        score += amount;
    }

    private void UpdateScoreUI()
    {
        scoreAmount.text = score.ToString("0");
    }
}
