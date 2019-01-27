using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandom : MonoBehaviour
{
    public AudioSource[] audioSources;
    public bool playRandomOnAwake;

    private void Start()
    {
        if (playRandomOnAwake)
        {
            PlayRand();
        }
    }

    public void PlayRand()
    {
        if(audioSources != null && audioSources.Length > 0)
        {
            var audioSource = audioSources[(int)(Random.value * audioSources.Length)];

            audioSource.Play();
        }
    }
}
