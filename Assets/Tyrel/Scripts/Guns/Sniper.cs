using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : GunFire
{
    public float fireRate = 0.5f;

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
