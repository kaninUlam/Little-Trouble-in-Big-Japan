﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreAudio : MonoBehaviour
{

    
    public AudioSource aSource = null;
    public AudioSource MenuASource = null;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayLore());
    }

    


    IEnumerator PlayLore()
    {
        Debug.Log("LoreAudio");
        Time.timeScale = 0;
        PlayLoreAudio();

        yield return new WaitForSecondsRealtime(17);
        Time.timeScale = 1;
        PlayMenuMusic();
        animator.Play("LoreScreen");
    }


    void PlayLoreAudio()
    {
        aSource.Play();
    }

    void PlayMenuMusic()
    {
        MenuASource.Play();
    }
}
