using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRateUp : MonoBehaviour
{
    public Sniper sniper;
    public Shotgun shotgun;
    public AssualtRifle assualtRifle;

    public float assualtFireRate = 0.1f;
    public float shotgunFireRate = 0.5f;
    public float sniperFireRate = 0.25f;


    public void FireRateUpPerk()
    {
        sniper.fireRate = sniperFireRate;
        shotgun.fireRate = shotgunFireRate;
        assualtRifle.fireRate = assualtFireRate;
    }

}
