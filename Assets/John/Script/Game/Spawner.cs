using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 0.25f;
    public float TimeBetweenSpawnning = 10f;

    public int enemyCount;

    public bool waveIsDone = true;

    public GameObject enemyClone;
    public GameObject enemy;
    public GameObject EnemyHolder;
    public GameObject[] spawners = null;
    public List<GameObject> enemyStorage = new List<GameObject>();
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
            enemyCount += 3;
            SpawnRate -= 0.1f;
        }
    }
    IEnumerator waveSpawner()
    {
        waveIsDone = false;
       
        for (int i = 0; i < enemyCount; i++)
        {
            foreach (GameObject obj in spawners)
            {
                enemyClone = Instantiate(enemy, obj.transform.position, obj.transform.rotation, EnemyHolder.transform);
                enemyClone.AddComponent<SpawnerRemover>().mySpawner = this;
                enemyStorage.Add(enemyClone);
                yield return new WaitForSeconds(SpawnRate);
            }
        }
/*
        SpawnRate -= 0.1f;
        enemyCount += 3;*/

        yield return new WaitForSeconds(TimeBetweenSpawnning);

        waveIsDone = true;
    }
    public void RemoveFromList(GameObject enemyToRemove)
    {
        enemyStorage.Remove(enemyToRemove);
    }
}
