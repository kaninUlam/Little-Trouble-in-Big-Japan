using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;

    public GameObject dropItem;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemyHealth = enemyHealth;
    }

    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(dropItem, transform.position, Quaternion.identity);

                
        }
    }
}
