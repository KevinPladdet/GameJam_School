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

    public static void PlayEatSound()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public static void StopEatSound()
    {
        _audioSource.Stop();
    }
}
