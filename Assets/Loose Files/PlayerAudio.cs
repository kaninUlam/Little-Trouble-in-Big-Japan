using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    private int RandomNum;



    public void RandomVoiceLine()
    {
        RandomNum = Random.Range(0, 100);
        Debug.Log("Random Number is " + RandomNum);
        int aIndex = Random.Range(0, aClips.Length);

        aSource.clip = aClips[aIndex];
        if(RandomNum >= 50)
        {
            PlayVoiceAudio(aClips[aIndex]);
        }
        
    }

    void PlayVoiceAudio(AudioClip clip)
    {
        Debug.Log("playing sounds");
        aSource.PlayOneShot(clip);
    }

}
