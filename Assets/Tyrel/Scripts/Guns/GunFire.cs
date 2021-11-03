using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public Transform gunEnd;

    public GameObject Projectile;


    public virtual void FireProjectile()
    {
        Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
    }

   
}
