using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : GunFire
{

    public SniperAmmo SAmmo;

    public float fireRate = 0.5f;

    public float nextFire;

    

    private void Start()
    {
        SAmmo.GetComponent<SniperAmmo>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && SAmmo.ammo > 0)
        {
            FireAssualtProjectile();
            nextFire = Time.time + fireRate;
        }
    }
}
