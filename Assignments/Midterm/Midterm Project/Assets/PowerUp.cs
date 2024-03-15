using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;
    public float flickerSpeed = 10f;
    private float flickerTimer = 0f;

    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            // Start the power-up effect
            StartCoroutine(StartPowerUp());
        }
    }

    IEnumerator StartPowerUp()
    {
        // Update GameManager properties
//        GameManager.PowerUp = 0.5f;     //power up used to change velocity of obj to emulate speed change. now i just change speed lol
        Time.timeScale = 0.5f;
        GameManager.PointsUntillPowerUp = Random.Range(10, 20);

        // Play sound clip
        if (soundClip != null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            audioSource.clip = soundClip;
            audioSource.Play();
        }

        // Wait for 5 seconds
        yield return new WaitForSeconds(2.5f);

        // Reset time scale
        Time.timeScale = 1.0f;

        // Destroy the power-up object
        Destroy(gameObject);
    }

    void Update() //flicker system
    {
        flickerTimer += Time.deltaTime * flickerSpeed;
        bool isVisible = (Mathf.FloorToInt(flickerTimer) % 2) == 0;
        GetComponent<SpriteRenderer>().enabled = isVisible;
    }
}
