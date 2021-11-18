using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public Health character;

    public float newHealth = 200;
    public HealthBar health;
    private void Start()
    {
        
    }
    public void HealthUpPerk()
    {
        character.GetComponent<Health>();
        health.SetMaxHealth(newHealth);
        newHealth = character.currentHealthPoints * 2;

        character.maxHealthPoints = newHealth;
        character.currentHealthPoints = newHealth;
    }
}
