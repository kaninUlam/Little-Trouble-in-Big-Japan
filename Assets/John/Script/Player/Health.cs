using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealthPoints = 100;
    public float currentHealthPoints = 100;
    
    public DeathAudio dAudio;
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    bool notAlive = false;

    

    public HealthBar healthBar;
    private void Start()
    {
        notAlive = false;
        currentHealthPoints = maxHealthPoints;
        healthBar.SetMaxHealth(maxHealthPoints);
    }
    private void Update()
    {
        if (currentHealthPoints <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void TakeDamageOverTime(float amount)
    {
        currentHealthPoints -= Time.deltaTime * amount;
        healthBar.SetHealth(currentHealthPoints);
        if (currentHealthPoints <= 0 && notAlive == false)
        {
            StartCoroutine(dAudio.GetComponent<DeathAudio>().OnDeathSounds());
            DeathSound();
            notAlive = true;
        }
    }

    public void takeDamage(float amount)
    {
        currentHealthPoints -= amount;
        healthBar.SetHealth(currentHealthPoints);
        if (currentHealthPoints <= 0)
        {
            DeathSound();
            dAudio.GetComponent<DeathAudio>().OnDeathSounds();
        }
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
