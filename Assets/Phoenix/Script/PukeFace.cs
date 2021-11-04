using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PukeFace : AiBehaviour
{
    [SerializeField] private float startingHP = 150;
    private float currentHP;

    private PukeFace ai;
    private float threshold;

    private void Start()
    {
        currentHP = startingHP;
    }

    public float GetCurrentHP()
    {
        return currentHP;
    }
}
