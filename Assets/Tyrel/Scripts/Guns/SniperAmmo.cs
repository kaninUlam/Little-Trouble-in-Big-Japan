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
            Debug.Log("Hit");
            sniper.ammo += 20;
            Destroy(gameObject);
            
        }

       
    }

    private void Update()
    {
        Destroy(gameObject, 60f);
    }
}
