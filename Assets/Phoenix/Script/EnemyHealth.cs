using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 200;
    public float MaxEnemyHealth = 200;
    public float Points = 0;

    //From pointSystem Script it will be called uiManager
    

    public GameObject dropItem;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemyHealth = enemyHealth;
        //_uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }

    public void takeDamage(float amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            Instantiate(dropItem, transform.position, Quaternion.identity);
            pointSystem.Instance.UpdateScore();

            Destroy(gameObject);
        }
    }
}
