using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : GunFire
{

    public float ammo = 0;

    public float fireRate = 1f;
    float normalFireRate = 1f;
    public float nextFire;

    public GunDamage gunDamage;
    public float newDamage = 150;
    

    void Start()
    {
        gunDamage.GetComponent<GunDamage>();
        fireRate = normalFireRate;
        newDamage = 150;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && ammo > 0)
        {
            gunDamage.DamageDealt = newDamage;
            FireAssualtProjectile();
            ammo--;
            nextFire = Time.time + fireRate;
        }
    }
}
