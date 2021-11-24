using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreAudio : MonoBehaviour
{

    
    public AudioSource aSource = null;


    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayLore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator PlayLore()
    {
        Time.timeScale = 0;
        

        yield return new WaitForSecondsRealtime(4);
        Time.timeScale = 1;
        animator.Play("LoreScreen");
    }


    void PlauLoreAudio()
    {
        aSource.Play();
    }
}
