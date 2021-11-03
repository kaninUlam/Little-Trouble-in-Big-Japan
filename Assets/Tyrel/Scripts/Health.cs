using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HealthPoints = 100;


    public void TakeDamage(float amount)
    {
        HealthPoints -= amount;
        if (HealthPoints <= 0)
        {
            Destroy(gameObject);
        }

    }
}
