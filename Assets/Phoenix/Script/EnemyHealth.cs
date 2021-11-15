using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Health Points
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;

    // Point System Link
    public pointSystem _uiManager;

    // What itme it will drop
    public GameObject dropItem;

    // Start is called before the first frame update
    void Start()
    {
        // Max Health Represnets the Enemy HP
        MaxEnemyHealth = enemyHealth;
    }

    // When Ai takes Damage
    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        // If the enemy reaches 0 HP it will be destroyed and drops an Item
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(dropItem, transform.position, Quaternion.identity);

            if (_uiManager != null)
            {
                _uiManager.UpdateScore(20);
            }
        }
    }
}
