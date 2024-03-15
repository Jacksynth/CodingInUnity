using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeleter : MonoBehaviour
{
   
void OnTriggerEnter2D(Collider2D otherCollider)
{
    // Check if the other collider has the "ObstacleBorder" tag
    if (otherCollider.CompareTag("ObstacleBorder"))
    {
        // Destroy the GameObject only if it comes into contact with an object with the "ObstacleBorder" tag
        Destroy(gameObject);
    }
}

    }

