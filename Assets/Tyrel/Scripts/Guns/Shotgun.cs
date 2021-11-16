using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : GunFire
{
    public float fireRate = 1f;
    float normalFireRate = 1f;
    public float nextFire;

    public float ammo = 0;

    public GunRayCast gunDamage;
    public float newDamage = 5;
    public Animator animator;

    float range = 20;

    void Start()
    {
        gunDamage.GetComponent<GunDamage>();
        fireRate = normalFireRate;
        newDamage = 20;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire && ammo > 0)
        {
            gunDamage.DamageDealt = newDamage;
            gunDamage.weaponRange = range;
            FireProjectile();
            animator.Play("Shotgun");
            ammo--;
            nextFire = Time.time + fireRate;
        }
    }

    

}
