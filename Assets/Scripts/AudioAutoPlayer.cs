using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAutoPlayer : MonoBehaviour
{
    public AudioClip audioToPlay;
    public float timeToPlay;

    private void OnEnable()
    {
        StartCoroutine(nameof(PlayAudio));
    }

    private IEnumerator PlayAudio()
    {
        while (AudioManager.instance == null)
        {
            yield return new WaitForEndOfFrame();
        }

        StartCoroutine(AudioManager.instance.PlayAudio(audioToPlay, timeToPlay));
    }

    public void StopAudio()
    {
        AudioManager.instance.StopAudio();
    }

    private void OnDisable()
    {
        AudioManager.instance.StopAudio();
    }
}
