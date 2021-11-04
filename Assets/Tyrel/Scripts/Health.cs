using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : ParticleSpawn
{
    public float HealthPoints = 100;


    public void TakeDamage(float amount)
    {
        HealthPoints -= amount;
        if (HealthPoints <= 0)
        {
            Destroy(gameObject);
            Instantiate(EnemyParticleDeath, transform.position, transform.rotation);
        }

    }
}
