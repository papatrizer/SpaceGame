using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] sounds;

    private AudioSource audioSource => GetComponent<AudioSource>();

    public void PlaySound(AudioClip clip, float volume)
    {
        audioSource.PlayOneShot(clip, volume);  
    }
}
