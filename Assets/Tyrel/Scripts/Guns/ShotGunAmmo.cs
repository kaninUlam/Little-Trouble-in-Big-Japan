using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunAmmo : MonoBehaviour
{
    public Shotgun shotgunAmmo;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            shotgunAmmo.ammo += 20;
            Destroy(gameObject);

        }


    }
}
