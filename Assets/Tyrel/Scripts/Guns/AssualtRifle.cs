using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssualtRifle : GunFire
{
    public float fireRate = 0.25f;

    public float nextFire;

    

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            FireAssualtProjectile();
            nextFire = Time.time + fireRate;
        }
    }
}
