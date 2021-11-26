using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FlashRedWhenHitByEnemy : MonoBehaviour
{
    PostProcessVolume _volume;
    Vignette _vignette;
    float duration = 0.25f;
    private void Start()
    {
        /*GameObject something = GameObject.FindGameObjectWithTag("PostProcessVignette");
        _volume = something.GetComponent<PostProcessVolume>();   // works when multiple post process present in scene need to set tag to inspector*/


        _volume = GameObject.FindObjectOfType<PostProcessVolume>();// works if one post process present in scene
        _volume.profile.TryGetSettings<Vignette>(out _vignette);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(FlashRed());
        }
    }
    IEnumerator FlashRed()
    {
        float alpha = 1;
        while ( alpha > 0)
        {
            alpha -= 1 / duration * Time.deltaTime;
            _vignette.intensity.value = alpha;
            yield return new WaitForEndOfFrame();
        }
    }
}