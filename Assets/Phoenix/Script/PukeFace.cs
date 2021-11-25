using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PukeFace : AiBehaviour
{

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;
    bool audioPlayed = false;

    //public float attackRange = 0;
    public float attackDelay = 3;
    //private float nextAttack = 0;
    private float attackDelayTimer = 0;

    public GameObject puke;

    public override void Start()
    {
        base.Start();

    }

    public override void Update()
    {
        base.Update();
        ShootPlayer();
        if (!audioPlayed)
        {
            StartCoroutine(PlayAudio());
            audioPlayed = true;
        }
    }

    private void ShootPlayer()
    {
        attackDelayTimer -= Time.deltaTime;

        if (attackDelayTimer >= 0) return;

        attackDelayTimer = attackDelay;

        Vector3 pos = new Vector3(0f, 10f, 0f);

        GameObject pukeProjectile = Instantiate(puke, transform.position + pos, transform.rotation);

        //Rigidbody rb = pukeProjectile.GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
        //rb.AddForce(transform.up * 6f, ForceMode.Impulse);

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
