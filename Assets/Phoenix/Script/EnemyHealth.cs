using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    // Stats
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;
    public float Points = 0;
    // Drop Rate Percentage
    public const float _dropRate = 0.45f;

    // From pointSystem Script it will be called uiManager
    //public pointSystem points;

    // Drop Items
    public GameObject[] dropItem;
    // Particle Effect
    public GameObject enemyDeathParticle;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemyHealth = enemyHealth;
        //_uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }
   
    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            if (Random.Range(0f, 1f) <= _dropRate) // Percentage to drop with the Rate
            {
                int indexToDrop = Random.Range(0, dropItem.Length); // Drop Items
                Instantiate(dropItem[indexToDrop], transform.position, Quaternion.identity); // What it Drops
            }

            pointSystem.Instance.UpdateScore(Points);

            Destroy(gameObject);
            Instantiate(enemyDeathParticle, transform.position, transform.rotation);
        }
    }
}
