using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomSoundManager : MonoBehaviour
{
    private static AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public static void PlayMomSound()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public static void StopMomSound()
    {
        _audioSource.Stop();
    }
}
