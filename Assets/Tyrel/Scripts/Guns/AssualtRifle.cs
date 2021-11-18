using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssualtRifle : GunFire
{
    public float fireRate = 0.5f;
    float normalFireRate = 0.5f;
    public float nextFire;

    public GunRayCast gunDamage;
    public float newDamage = 50;

    public Animator animator;

    float range = 2000;

    void Start()
    {
        gunDamage.GetComponent<GunDamage>();
        newDamage = 50;
        fireRate = normalFireRate;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            gunDamage.DamageDealt = newDamage;
            gunDamage.weaponRange = range;
            FireAssualtProjectile();
            animator.Play("AssualtRifle");
            nextFire = Time.time + fireRate;
        }
        
    }


    
}
