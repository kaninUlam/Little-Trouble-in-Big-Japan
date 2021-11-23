using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool mouseOver = false;

    Vector3 pos;
    Vector3 newPos;

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;



    private void Start()
    {
       

        pos = transform.position;
        newPos = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    }

    private void OnMouseOver()
    {
        mouseOver = true;
        
        transform.position = newPos;
        
    }
    private void OnMouseExit()
    {
        mouseOver = false;
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

    void OnMouseEnter()
    {
        MenuSound();
    }

    private void Update()
    {

        

        if(mouseOver == false)
        {
            transform.position = pos;
        }
    }

}
