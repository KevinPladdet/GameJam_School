using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingAudioManager : MonoBehaviour
{
    private static AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public static void StopSound()
    {
        _audioSource.Stop();
    }
}
