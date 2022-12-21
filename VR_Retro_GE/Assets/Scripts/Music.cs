using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music: MonoBehaviour
{
    // An array of audio clips to play
    public AudioClip[] audioClips;

    // An audio source to play the music
    private AudioSource audioSource;

    // The current index of the audio clip being played
    private int currentClipIndex = 0;

    void Start()
    {
        // Get the audio source component and set the first clip to play
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();
    }

    void Update()
    {
        // Check for keyboard input to switch between songs
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Increment the current clip index and wrap around if necessary
            currentClipIndex = (currentClipIndex + 1) % audioClips.Length;
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Decrement the current clip index and wrap around if necessary
            currentClipIndex = (currentClipIndex - 1 + audioClips.Length) % audioClips.Length;
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
        }
    }
}