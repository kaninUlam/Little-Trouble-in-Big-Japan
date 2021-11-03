using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleEnemy : MonoBehaviour
{
    public int damagetaken = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health healthcomp = GetComponent<Health>();
            if (healthcomp != null)
            {
                healthcomp.takeDamage(damagetaken);
            }
           
        }
    }
}
