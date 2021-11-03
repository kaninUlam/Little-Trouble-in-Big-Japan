using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : GunFire
{
    public float spread = 5;
    public float Damage = 10;

    public override void FireProjectile()
    {
        for (int i = 10; i >= 0; i--)
        {
            GameObject Shells = Instantiate(Projectile, transform.position, transform.rotation);
            Shells.transform.Rotate(0, Random.Range(spread, -spread), 0);

        }
    }

}
