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

    // Drop Chance
    public const float _dropRate = 1 / 8;
    public GameObject[] dropItem;

    //From pointSystem Script it will be called uiManager
    //public pointSystem points;

    void Start()
    {
        MaxEnemyHealth = enemyHealth; // Enemy HP
        //_uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }
   
    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            if (Random.Range(0, 1) <= _dropRate)
            {
                int indexToDrop = Random.Range(0, dropItem.Length);
                Instantiate(dropItem[indexToDrop], transform.position, Quaternion.identity);
            }

            pointSystem.Instance.UpdateScore(Points);
            Destroy(gameObject);
        }
    }
}
