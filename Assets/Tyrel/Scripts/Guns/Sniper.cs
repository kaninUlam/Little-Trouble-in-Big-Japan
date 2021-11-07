using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : GunFire
{

    public float ammo = 0;

    public float fireRate = 0.5f;

    public float nextFire;

    

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && ammo > 0)
        {
            FireAssualtProjectile();
            ammo--;
            nextFire = Time.time + fireRate;
        }
    }
}
