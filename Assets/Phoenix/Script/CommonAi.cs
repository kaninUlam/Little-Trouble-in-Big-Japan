using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommonAi : AiBehaviour
{
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    public override void Start()
    {
        base.Start();

    }
    public override void Update()
    {
        base.Update();

        if (!audioPlayed)
        {
            StartCoroutine(PlayAudio());
            audioPlayed = true;
        }
    }

    IEnumerator PlayAudio()
    {
        yield return new WaitForSeconds(10);

        audioPlayed = false;

        HyogenSound();
    }

    void HyogenSound()
    {
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];

        PlayHyogenSound(aClips[aIndex]);
    }

    void PlayHyogenSound(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }
}
