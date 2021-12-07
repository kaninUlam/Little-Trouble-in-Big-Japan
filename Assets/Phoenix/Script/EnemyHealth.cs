using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    //Audio
    public PlayerAudio playerAudio;
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    // Stats
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;
    public float Points = 0;

    // Drop Rate Percentage
    //public const float _dropRate = 0.65f;

    // Drop Items
    [SerializeField]
    public GameObject[] dropItem; //Stores the Drops
    /*private int itemNum;*/ // the Item Number
    private int randNum; // Random Number
    Vector3 pos = new Vector3(0f, 3.5f, 0f);

    // Particle Effect
    public GameObject enemyDeathParticle;

    void Start()
    {
        // Max Health Represnets the Enemy HP
        MaxEnemyHealth = enemyHealth;
    }
   
    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        // If the enemy reaches 0 HP it will be destroyed and drops an Item
        if (enemyHealth <= 0)
        {
            //if (Random.Range(0f, 1f) <= _dropRate) // Percentage to drop with the Rate
            //    Debug.Log(_dropRate);
            //{
            //    int indexToDrop = Random.Range(0, dropItem.Length); // Drop Items
            //    GameObject DropedItem = Instantiate(dropItem[indexToDrop], transform.position + Vector3.up, Quaternion.identity); // What it Drops
            //    Debug.Log(dropItem.Length);
            //    Destroy(DropedItem, 25);
            //}

            randNum = Random.Range(1, 70);
            Debug.Log(randNum);

            if (randNum >= 30)
            {
                int indexToDrop = Random.Range(0, dropItem.Length); // Drop Items
                GameObject DropedItem = Instantiate(dropItem[indexToDrop], transform.position + pos, Quaternion.identity); // What it Drops
                Destroy(DropedItem, 15);
            }
            //else if (randNum > 75 && randNum < 95)
            //{
            //    itemNum = 1;
            //    Instantiate(dropItem[itemNum], transform.position + Vector3.up, Quaternion.identity);
            //}
            //else if (randNum > 40 && randNum < 75)
            //{
            //    itemNum = 2;
            //    Instantiate(dropItem[itemNum], transform.position + Vector3.up, Quaternion.identity);
            //}

            DifferentPointSystem.Points.UpdateScore(Points);

            //plays audio on death
            playerAudio.GetComponent<PlayerAudio>().RandomVoiceLine();
            DeathSound();

            //Destroy Hyogen
            Destroy(gameObject);
            Instantiate(enemyDeathParticle, transform.position + Vector3.up * 5, transform.rotation);
        }
    }


    void DeathSound()
    {
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];

        PlayDeathSound(aClips[aIndex]);
    }

    void PlayDeathSound(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }

}
