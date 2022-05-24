using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    /// <summary>
    /// Plays an audio with an interval to start.
    /// </summary>
    /// <param name="audioToPlay">The audio you want to be played.</param>
    /// <param name="timeToStart">Time in seconds to start to play the audio.</param>
    public IEnumerator PlayAudio(AudioClip audioToPlay, float timeToStart)
    {
        audioSource.Stop();
        yield return new WaitForSeconds(timeToStart);
        audioSource.clip = audioToPlay;
        audioSource.Play();
    }

    public void PlayAudio(AudioClip audioToPlay)
    {
        audioSource.Stop();
        audioSource.clip = audioToPlay;
        audioSource.Play();
    }

    public void PlayAudioAndLoop(AudioClip audioToPlay)
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = audioToPlay;
            audioSource.Play();
        }
    }

    public void StopAudio()
    {
        if(audioSource != null)
            audioSource.Stop();
    }
}
