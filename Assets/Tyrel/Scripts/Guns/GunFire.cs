using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    

    public GameObject Projectile;
    public Transform gunEnd;

    public float spread = 5;

    public float assualtRange = 1;
    public float shotgunRange = 0.2f;
    

    public virtual void FireProjectile()
    {
        for (int i = 10; i >= 0; i--)
        {
            GameObject Shells = Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
            Shells.transform.Rotate(Random.Range(spread, -spread), Random.Range(spread, -spread), 0);
            Destroy(Shells, shotgunRange);

        }
    }

    public void FireAssualtProjectile()
    {
        GameObject bullets = Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
        Destroy(bullets, assualtRange);
    }

   
}
