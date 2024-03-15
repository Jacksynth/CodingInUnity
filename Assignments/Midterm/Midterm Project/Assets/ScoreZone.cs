using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public GameObject soundEffectPrefab;

    void OnTriggerEnter2D(Collider2D Other) 
    {
        if (Other.CompareTag("Player"))
    {
        // Instantiate the sound effect prefab at the position of this GameObject
        GameObject soundEffectInstance = Instantiate(soundEffectPrefab, transform.position, Quaternion.identity);
        AudioSource audioSource = soundEffectInstance.GetComponent<AudioSource>();
        Destroy(soundEffectInstance, audioSource.clip.length);
        Destroy(gameObject);
        GameManager.Score++;
        GameManager.PointsUntillPowerUp--;
        

    }
    }
}
