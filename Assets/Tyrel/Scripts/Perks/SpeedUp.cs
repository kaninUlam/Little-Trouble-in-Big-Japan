using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public CharacterMovement character;

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    public void SpeedUpPerk()
    {
        character.GetComponent<CharacterMovement>();
        character.speed = character.speed * 2;
        character.runSpeed = character.runSpeed * 2;
        character.normalSpeed = character.normalSpeed * 2;
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
