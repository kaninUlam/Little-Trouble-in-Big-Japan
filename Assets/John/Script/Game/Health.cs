using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealthPoints = 100;
    public float currentHealthPoints = 100;
    
    public DeathAudio dAudio;

    bool notAlive = false;

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    public HealthBar healthBar;
    private void Start()
    {
        notAlive = false;
        currentHealthPoints = maxHealthPoints;
        healthBar.SetMaxHealth(maxHealthPoints);
    }
    public void TakeDamageOverTime(float amount)
    {
        currentHealthPoints -= Time.deltaTime * amount;
        healthBar.SetHealth(currentHealthPoints);
        if (currentHealthPoints <= 0 && notAlive == false)
        {
            StartCoroutine(dAudio.GetComponent<DeathAudio>().OnDeathSounds());
            notAlive = true;
        }
    }
    public void takeDamage(float amount)
    {
        currentHealthPoints -= amount;
        healthBar.SetHealth(currentHealthPoints);
        if (currentHealthPoints <= 0)
        {

            dAudio.GetComponent<DeathAudio>().OnDeathSounds();
        }
    }

    
}
