using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolumControl : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer = null;

    public void SetVolume(float Value)
    {
        audioMixer.SetFloat("Musics", Mathf.Log10(Value) * 20);
        audioMixer.SetFloat("MasterSFX", Mathf.Log10(Value) * 20);
    }


}
