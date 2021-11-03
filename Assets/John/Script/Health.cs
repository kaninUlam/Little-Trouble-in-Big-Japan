using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HealthPoints = 100;
    public void TakeDamageOverTime(float amount)
    {
        HealthPoints -= Time.deltaTime * amount;
        if(HealthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
