using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : GunFire
{
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;


    public float ammo = 0;

    public float fireRate = 1f;
    float normalFireRate = 1f;
    public float nextFire;

    public GunRayCast gunDamage;
    public float newDamage = 150;

    public Animator animator;

    float range = 20;

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
            gunDamage.weaponRange = range;
            FireSniperProjectile();
            RandomGunAudio();
            animator.Play("Sniper");
            ammo--;
            nextFire = Time.time + fireRate;
        }
    }

    void RandomGunAudio()
    {
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];

        PlayGunAudio(aClips[aIndex]);
    }

    void PlayGunAudio(AudioClip clip)
    {

        aSource.PlayOneShot(clip);

    }
}
