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

    public const float m_dropChance = 1f / 10f;

    //From pointSystem Script it will be called uiManager
    //public pointSystem points;

    public GameObject dropItem;

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
            if (Random.Range(0f, 1f) <= m_dropChance)
            {
                Instantiate(dropItem, transform.position, Quaternion.identity);
            }

            pointSystem.Instance.UpdateScore(Points);

            Destroy(gameObject);
        }
    }
}
