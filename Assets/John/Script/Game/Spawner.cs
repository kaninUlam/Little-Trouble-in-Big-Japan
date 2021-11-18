using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 0.25f;
    public float TimeBetweenSpawnning = 10f;


    public int enemyCount;
    public int WaveCount;

    public bool waveIsDone = true;

    public GameObject EnemyHolder;

    public List<GameObject> Enemies = new List<GameObject>();
    public List<GameObject> enemyStorage = new List<GameObject>();
    public GameObject[] spawners = null;
    private void Start()
    {
        EnemyHolder = new GameObject("EnemyHolder");
    }
    // Update is called once per frame
    void Update()
    {
        if (enemyStorage.Count <= 0 && waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
        if (enemyStorage.Count <= 0 && waveIsDone == false)
        {
            waveIsDone = true;
            IncreaseDifficulty();
        }
    }

    IEnumerator waveSpawner()
    {

        if (waveIsDone == true)
        {
            waveIsDone = false;
            WaveCount++;

            for (int i = 0; i < enemyCount; i++)
            {
                foreach (GameObject obj in spawners)
                {
                    GameObject enemyClone = Enemies[Random.Range(0, Enemies.Count)];
                    GameObject CurrentEnemy = Instantiate(enemyClone, obj.transform.position, obj.transform.rotation, EnemyHolder.transform);
                    enemyStorage.Add(CurrentEnemy);
                    yield return new WaitForSeconds(SpawnRate);
                }
            }
            
        }

    }
    public void RemoveFromList(GameObject enemyToRemove)
    {
        enemyStorage.Remove(enemyToRemove);
    }
    void IncreaseDifficulty()
    {
        TimeBetweenSpawnning -= 1;
        SpawnRate -= 0.1f;
        enemyCount += 1;
    }
    
}
