using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForWave : MonoBehaviour
{
    public GameObject WaveCheck;
    public Text text;

    public Spawner Enemycheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyRemaining();
    }
    void EnemyRemaining()
    {
        text.text = "Enemy Remaining: " + Enemycheck.enemyStorage.Count;
    }
}
