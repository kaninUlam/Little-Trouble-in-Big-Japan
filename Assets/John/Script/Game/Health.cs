using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealthPoints = 100;
    public float currentHealthPoints = 100;

    public HealthBar healthBar;
    private void Start()
    {
        currentHealthPoints = maxHealthPoints;
        /*healthBar.SetMaxHealth(maxHealthPoints);*/
    }
    public void TakeDamageOverTime(float amount)
    {
        currentHealthPoints -= Time.deltaTime * amount;
        /*healthBar.SetHealth(currentHealthPoints);*/
        if (currentHealthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void takeDamage(float amount)
    {
        currentHealthPoints -= amount;
/*        healthBar.SetHealth(currentHealthPoints);*/
        if (currentHealthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
