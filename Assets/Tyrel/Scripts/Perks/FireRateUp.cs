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

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    public void FireRateUpPerk()
    {
        sniper.fireRate = sniperFireRate;
        shotgun.fireRate = shotgunFireRate;
        assualtRifle.fireRate = assualtFireRate;
    }

    private void Update()
    {
        if (!audioPlayed)
        {
            StartCoroutine(PlayAudio());
            audioPlayed = true;
        }
    }

    IEnumerator PlayAudio()
    {
        yield return new WaitForSeconds(60);

        audioPlayed = false;

        MenuSound();
    }

    void MenuSound()
    {
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];

        PlayMenuSound(aClips[aIndex]);
    }

    void PlayMenuSound(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }

}
