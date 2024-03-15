using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateSwitcher : MonoBehaviour
{
public AudioClip soundClip; // Assign the audio clip in the Unity Editor
    private AudioSource audioSource;
//GameManager GameState;
void OnTriggerEnter2D(Collider2D otherCollider)
{
    //GameState = GetComponent<GameManager>();
    // Check if the other collider has the "ObstacleBorder" tag
    if (otherCollider.CompareTag("Obstacle"))
    {
        GameManager.GameState = 0;
        Time.timeScale = 0;
        gameObject.GetComponent<PlayerMovement>().enabled = false;

                audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there's no AudioSource attached, add one
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the AudioClip to the AudioSource
        audioSource.clip = soundClip;

        // Play the audio clip
        audioSource.Play();

    }
}

    }

