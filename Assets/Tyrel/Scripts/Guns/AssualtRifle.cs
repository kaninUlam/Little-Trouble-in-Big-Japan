using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssualtRifle : GunFire
{
    public float fireRate = 0.5f;
    float normalFireRate = 0.5f;
    public float nextFire;


    private void Start()
    {
        fireRate = normalFireRate;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            FireAssualtProjectile();
            nextFire = Time.time + fireRate;
        }
    }
}
