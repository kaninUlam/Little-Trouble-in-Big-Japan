using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperAmmo : MonoBehaviour
{
    public Sniper sniper;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sniper.ammo += 5;
            Destroy(gameObject);
            
        }

       
    }

    private void Update()
    {
        Destroy(gameObject, 30f);
    }
}
