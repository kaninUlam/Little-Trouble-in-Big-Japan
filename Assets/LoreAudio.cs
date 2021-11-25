using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreAudio : MonoBehaviour
{

    
    public AudioSource aSource = null;
    public AudioSource MenuASource = null;

    public Animator animator;
    public GameObject fullBlack;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayLore());
    }

    


    IEnumerator PlayLore()
    {

        fullBlack.SetActive(true);
        PlayLoreAudio();
        
        yield return new WaitForSecondsRealtime(17);
        
        PlayMenuMusic();
        animator.Play("LoreScreen");
        StartCoroutine(FullBlackActive());
    }

    IEnumerator FullBlackActive()
    {
        yield return new WaitForSeconds(1);

        fullBlack.SetActive(false);
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
