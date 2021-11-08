using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : GunFire
{
    public float fireRate = 1f;
    float normalFireRate = 1f;
    public float nextFire;

    public float ammo = 0;


    private void Start()
    {
        fireRate = normalFireRate;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && ammo > 0)
        {
            FireProjectile();
            nextFire = Time.time + fireRate;
        }
    }

    

}
