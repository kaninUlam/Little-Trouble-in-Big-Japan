﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAudio : MonoBehaviour
{

    public GameManager gameManager;
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    

    public IEnumerator OnDeathSounds()
    {
        Time.timeScale = 0;
        DeathSound();
        
        gameManager.GetComponent<GameManager>().OnDeath();
        yield return new WaitForSeconds(0.1f);
        
    }


    void DeathSound()
    {
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];

        PlayDeathSound(aClips[aIndex]);

    }

    void PlayDeathSound(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }
}
