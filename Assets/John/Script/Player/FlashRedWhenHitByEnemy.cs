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
        _volume = GameObject.FindObjectOfType<PostProcessVolume>();
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