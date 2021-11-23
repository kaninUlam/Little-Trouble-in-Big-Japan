using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunDamage : Health
{

    
    public float DamageDealt = 50;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            Debug.Log(DamageDealt);
        }

        if (collision.collider.tag == "Enemy" && collision.collider.tag == "Cold")
        {
            EnemyHealth enemyHP = collision.gameObject.GetComponent<EnemyHealth>();
            Health healthComponent = collision.gameObject.GetComponent<Health>();
            if (healthComponent != null)
            {
                Debug.Log(DamageDealt);
                Destroy(gameObject);
                healthComponent.takeDamage(DamageDealt);

            }

            if (enemyHP != null)
            {
                Destroy(gameObject);
                enemyHP.takeDamage(DamageDealt);
            }

        }

    }

}
