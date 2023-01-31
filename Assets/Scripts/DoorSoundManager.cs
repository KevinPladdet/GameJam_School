using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundManager : MonoBehaviour
{
    public AudioClip creak;
    public AudioClip open;
    public AudioClip close;

    private static AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Mother.Peeking == true)
        {
            PlayCreakSound();
        }
        if (Mother.Entering == true)
        {
            PlayOpenSound();
        }
        if (Mother.Leaving == true)
        {
            PlayCloseSound();
        }
    }

    public void PlayCreakSound()
    {
        _audioSource.clip = creak;
        if (_audioSource.isPlaying) return;
        _audioSource.volume = 0.5f;
        _audioSource.Play();
        Debug.Log("play creak");
    }
    public void PlayOpenSound()
    {
        _audioSource.clip = open;
        if (_audioSource.isPlaying) return;
        _audioSource.volume = 1;
        _audioSource.Play();
    }
    public void PlayCloseSound()
    {
        _audioSource.clip = close;
        if (_audioSource.isPlaying) return;
        _audioSource.volume = 1;
        _audioSource.Play();
    }

    public static void StopSound()
    {
        _audioSource.Stop();
    }
}
