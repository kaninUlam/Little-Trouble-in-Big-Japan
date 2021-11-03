using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : GunFire
{
    public float fireRate = 1f;

    public float nextFire;

    


    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            FireProjectile();
            nextFire = Time.time + fireRate;
        }
    }

    

}
