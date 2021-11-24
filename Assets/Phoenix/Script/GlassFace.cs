using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GlassFace : AiBehaviour
{
    // Sound
    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    // Timer and Area

    //public float delay = 3f;
    //float countdown;
    //EnemyHealth HP;
    //bool hasGoneOff = false;
    //public GameObject effect;
    //public float radius = 5f;
    //public float force = 100f;
    //Health playerHP;

    public override void Start()
    {
        base.Start();
        //countdown = delay;
        //HP = GetComponent<EnemyHealth>();
    }

    public override void Update()
    {
        base.Update();
        
        //if ()
        //{
        //    countdown -= Time.deltaTime;
        //    if (countdown <= 0f && !hasGoneOff) // When Countdown reaches Zero
        //    {
        //        Suprise(); // Suprise goes off
        //        hasGoneOff = true; // When it goes off
        //    }
        //}

        if (!audioPlayed)
        {
            StartCoroutine(PlayAudio());
            audioPlayed = true;
        }
    }

    //void Suprise()
    //{
    //    Instantiate(effect, transform.position, transform.rotation); // Creates effect in place of Object

    //    Collider[] colliders = Physics.OverlapSphere(transform.position, radius); // What it will effect in area

    //    foreach (Collider nearbyObject in colliders)
    //    {
    //        Rigidbody rb = nearbyObject.GetComponent<Rigidbody>(); // Look for Rigidbody

    //        if (rb != null)
    //        {
    //            rb.AddExplosionForce(force, transform.position, radius); // Will effect those that have Rigidbody

    //        }

    //        nearbyObject.GetComponent<EnemyHealth>();
    //    }

    //    Destroy(gameObject);
    //}

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
