using System.Collections;
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
        
        yield return new WaitForSecondsRealtime(4);
        
        gameManager.GetComponent<GameManager>().OnDeath();
        
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
