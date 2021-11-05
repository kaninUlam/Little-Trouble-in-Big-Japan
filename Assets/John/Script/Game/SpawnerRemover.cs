using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRemover : MonoBehaviour
{
    public Spawner mySpawner;
    private void OnDestroy()
    {
        mySpawner.RemoveFromList(gameObject);
    }
}
