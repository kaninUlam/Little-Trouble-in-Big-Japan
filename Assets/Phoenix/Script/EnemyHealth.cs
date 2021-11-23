using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public PlayerAudio playerAudio;

    // Stats
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;
    public float Points = 0;
    // Drop Rate Percentage
    public const float _dropRate = 0.75f;

    // From pointSystem Script it will be called uiManager
    //public pointSystem points;

    // Drop Items
    public GameObject[] dropItem;
    // Particle Effect
    public GameObject enemyDeathParticle;

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
                Instantiate(dropItem[indexToDrop], transform.position + Vector3.up, Quaternion.identity); // What it Drops
            }

            DifferentPointSystem.Points.UpdateScore(Points);

            playerAudio.GetComponent<PlayerAudio>().RandomVoiceLine();

            Destroy(gameObject);
            Instantiate(enemyDeathParticle, transform.position + Vector3.up * 5, transform.rotation);
        }
    }
}
