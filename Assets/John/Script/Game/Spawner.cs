using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 0.25f;
    public float TimeBetweenSpawnning = 10f;

    public int enemyCount;

    public bool waveIsDone = true;
    
    public GameObject enemy;
    public GameObject EnemyHolder;
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
            StartCoroutine(waveSpawner());
        }
    }
    IEnumerator waveSpawner()
    {
        waveIsDone = false;
       
            for (int i = 0; i < enemyCount; i++)
        {
            foreach (GameObject obj in spawners)
            {
                GameObject enemyClone = Instantiate(enemy, obj.transform.position, obj.transform.rotation, EnemyHolder.transform);
                yield return new WaitForSeconds(SpawnRate);
            }
        }
        
        /*SpawnRate -= 0.1f;
        enemyCount += 3;*/

        yield return new WaitForSeconds(TimeBetweenSpawnning);

        waveIsDone = true;
    }
}
