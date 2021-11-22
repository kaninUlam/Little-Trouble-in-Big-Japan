using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    public int weaponSelected = 0;

    public GameObject Shotgun;
    public GameObject AssualtRifle;
    public GameObject Sniper;

    

    void Start()
    {
        weaponSelected = 1;

        GunsActive();
    }

    IEnumerator GunsActive()
    {
        Shotgun.SetActive(true);
        AssualtRifle.SetActive(true);
        Sniper.SetActive(true);
        
        yield return new WaitForSeconds(1);
        Shotgun.SetActive(false);
        AssualtRifle.SetActive(false);
        Sniper.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AssaultRifleSound(0);
            weaponSelected = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShotgunSound(1);
            weaponSelected = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SniperSound(2);
            weaponSelected = 3;
        }

        

        switch (weaponSelected)
        {
            case 1:
                
                Shotgun.SetActive(false);
                AssualtRifle.SetActive(true);
                Sniper.SetActive(false);
                break;

            case 2:
                
                Shotgun.SetActive(true);                
                AssualtRifle.SetActive(false);               
                Sniper.SetActive(false);
                
                break;

            case 3:
                
                Sniper.SetActive(true);
                Shotgun.SetActive(false);
                AssualtRifle.SetActive(false);
                break;
        }



        void ShotgunSound(int value)
        {
            int aIndex = value;

            aSource.clip = aClips[aIndex];


            PlaySwitchSound(aClips[aIndex]);
        }

        void SniperSound(int value)
        {
            int aIndex = value;

            aSource.clip = aClips[aIndex];

            PlaySwitchSound(aClips[aIndex]);
        }

        void AssaultRifleSound(int value)
        {
            int aIndex = value;

            aSource.clip = aClips[aIndex];

            PlaySwitchSound(aClips[aIndex]);
        }

        void PlaySwitchSound(AudioClip clip)
        {
            aSource.PlayOneShot(clip);
        }

    }
}
