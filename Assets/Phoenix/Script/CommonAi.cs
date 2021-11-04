using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommonAi : AiBehaviour
{
    [SerializeField] private float startingHP = 100;
    private float currentHP = 100;

    public float damageDealt;

    Health playerHP;

    private void Start()
    {
        currentHP = startingHP;
        playerHP = Player.GetComponent<Health>();
        StartCoroutine(attackDelay());
    }

    IEnumerator attackDelay()
    {
        yield return new WaitForSeconds(5);
    }

    public float GetCurrentHP()
    {
        return currentHP;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHP.takeDamage(damageDealt);
            
            //if (playerHP != null)
            //{
            //    playerHP.takeDamage(10f);
            //}
        }
    }
}
