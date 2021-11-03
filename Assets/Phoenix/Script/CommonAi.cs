using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonAi : AiBehaviour
{
    [SerializeField] private float startingHP;
    [SerializeField] private float lowHP;
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
