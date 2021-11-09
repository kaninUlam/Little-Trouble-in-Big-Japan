using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunDamage : MonoBehaviour
{

    
    public float DamageDealt = 50;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            Debug.Log(DamageDealt);
        }

        if (collision.collider.tag == "Enemy")
        {


            
            Health healthComponent = collision.gameObject.GetComponent<Health>();
            if (healthComponent != null)
            {
                Debug.Log(DamageDealt);
                Destroy(gameObject);
                healthComponent.takeDamage(DamageDealt);
            }

        }
    }


}
