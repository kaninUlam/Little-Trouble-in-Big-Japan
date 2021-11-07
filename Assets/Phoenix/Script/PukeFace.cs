using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PukeFace : AiBehaviour
{
    private PukeFace ai;
    private float threshold;

    [SerializeField] private float startingHP;
    private float currentHP;

    private void Start()
    {
        currentHP = startingHP;
    }

    public float GetCurrentHP()
    {
        return currentHP;
    } 
}
