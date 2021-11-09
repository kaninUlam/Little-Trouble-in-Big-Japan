using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUp : MonoBehaviour
{


    public AssualtRifle assault;
    public Shotgun shotgun;
    public Sniper sniper;

    public void DamageUpPerk()
    {
        assault.GetComponent<AssualtRifle>();
        assault.newDamage = 40;
        shotgun.GetComponent<Shotgun>();
        shotgun.newDamage = 100;
        sniper.GetComponent<Sniper>();
        sniper.newDamage = 300;

        Debug.Log(sniper.newDamage +"" +  shotgun.newDamage +"" +  assault.newDamage + "");
    }

}
