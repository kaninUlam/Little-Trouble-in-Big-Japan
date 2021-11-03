using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : GunFire
{
    public float fireRate = 0.25f;

    public float nextFire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > nextFire)
        {
            FireProjectile();
            nextFire = Time.time + fireRate;
        }
    }
}
