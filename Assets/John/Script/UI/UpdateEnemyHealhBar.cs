using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEnemyHealhBar : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(enemyHealth.MaxEnemyHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(enemyHealth.enemyHealth);
    }
}
