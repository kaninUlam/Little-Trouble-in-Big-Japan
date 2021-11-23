using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUp : MonoBehaviour
{
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

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
