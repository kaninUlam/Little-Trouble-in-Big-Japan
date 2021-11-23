using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public Health character;

    public float newHealth = 200;
    public HealthBar health;

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    private void Start()
    {
        
    }
    public void HealthUpPerk()
    {
        character.GetComponent<Health>();
        health.SetMaxHealth(newHealth);
        newHealth = character.currentHealthPoints * 2;

        character.maxHealthPoints = newHealth;
        character.currentHealthPoints = newHealth;
    }

    private void Update()
    {
        if(!audioPlayed)
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
