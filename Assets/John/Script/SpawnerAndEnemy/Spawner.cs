using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 0.25f;
    public float TimeBetweenSpawnning = 10f;

    public int enemyCount;
    public int WaveCount;
    
    public bool hasIncreasedDifficulty = false;
    public bool waveIsDone = true;

    public List<GameObject> Enemies = new List<GameObject>();
    public GameObject[] spawners = null;
   
    public List<GameObject> enemyStorage = new List<GameObject>();
    GameObject EnemyHolder;
    private void Start()
    {
        EnemyHolder = new GameObject("EnemyHolder");
        StartCoroutine(waveSpawner());
        WaveCount--;
    }
    // Update is called once per frame
    void Update()
    {
        if (enemyStorage.Count <= 0 && waveIsDone == true)
        {
            StartCoroutine(IncreaseDifficulty());
        }
        if (hasIncreasedDifficulty == true)
        {
            StartCoroutine(waveSpawner());
        }
       
    }
    IEnumerator waveSpawner()
    {

        if (waveIsDone == true)
        {
            waveIsDone = false;
            WaveCount++;
            hasIncreasedDifficulty = false;

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
            waveIsDone = true;
        }
    }
    IEnumerator IncreaseDifficulty()
    {
        yield return new WaitForSeconds(TimeBetweenSpawnning);
        if (enemyStorage.Count <= 0 && hasIncreasedDifficulty == false )
        {
            TimeBetweenSpawnning -= 1;
            SpawnRate -= 0.1f;
            enemyCount += 1;
            hasIncreasedDifficulty = true;
            Debug.Log("Spawnning next wave");
            Debug.Log("Time between spawning is now " + TimeBetweenSpawnning);
            Debug.Log("Spawn Rate is now " + SpawnRate);
            Debug.Log("Enemy Count is now " + enemyCount);
            
        }
    }
   
    public void RemoveFromList(GameObject enemyToRemove)
    {
        enemyStorage.Remove(enemyToRemove);
    }
   
    
}
