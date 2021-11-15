using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyListCheck : MonoBehaviour
{
    Health enemyHealth;
    Spawner listCheck;
    private void Start()
    {
        enemyHealth = GetComponent<Health>();
        listCheck = GetComponent<Spawner>();
    }
    private void Update()
    {
        if(enemyHealth.currentHealthPoints <= 0)
        {
        }
    }
}
