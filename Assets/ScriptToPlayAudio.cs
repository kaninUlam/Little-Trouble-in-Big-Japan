using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptToPlayAudio : MonoBehaviour
{

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    // Start is called before the first frame update
    void Start()
    {
        DeathSound();
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
