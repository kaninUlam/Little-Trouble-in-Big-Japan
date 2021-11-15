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
        if( waveIsDone == true)
        {
            if(enemyStorage.Count <= 0)
            {
                StartCoroutine(waveSpawner());
            }
        }
        if (Input.GetKeyDown("t"))
        {
            IncreaseDifficulty();
        }
    }
    void IncreaseDifficulty()
    {
        SpawnRate -= 0.1f;
        enemyCount += 3;
    }
    IEnumerator waveSpawner()
    {
        waveIsDone = false;
        WaveCount++;
       
        for (int i = 0; i < enemyCount; i++)
        {
            foreach (GameObject obj in spawners)
            {
                GameObject enemyClone = Enemies[Random.Range(0, Enemies.Count)];
                Instantiate(enemyClone, obj.transform.position, obj.transform.rotation, EnemyHolder.transform);
                yield return new WaitForSeconds(SpawnRate);
            }
        }
        if(enemyStorage.Count <= 0)
        {
            yield return new WaitForSeconds(TimeBetweenSpawnning);
            waveIsDone = true;
        }
    }
    public void RemoveFromList(GameObject enemyToRemove)
    {
        enemyStorage.Remove(enemyToRemove);
    }
}
