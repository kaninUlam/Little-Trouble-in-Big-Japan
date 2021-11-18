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
        
        //Enemycheck = GetComponent<Spawner>();
        WaveCheck.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemycheck.enemyStorage.Count <= 3)
        {

            WaveCheck.SetActive(true);
            EnemyRemaining();
        }
    }
    void EnemyRemaining()
    {
        text.text = "Enemy Remaining: " + Enemycheck.enemyStorage.Count;
    }
}
