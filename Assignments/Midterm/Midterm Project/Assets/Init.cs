using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public GameObject MemoryPrefab;
    //public GameObject ListenerPrefab;
    public GameObject HSUPrefab;
    private static bool hasLoaded = false; // Flag to track whether the scene has been loaded

    //private string switcho;

    void Start()
    //HiScoreUpdater.Instance.UpdateHighScoreUI(newHighScore);
    {
    if (!hasLoaded)
        {
        GameObject MemoryInstance = Instantiate(MemoryPrefab, transform.position, Quaternion.identity);
       // GameObject ListenerInstance = Instantiate(ListenerPrefab, transform.position, Quaternion.identity);
        GameObject HSUInstance = Instantiate(HSUPrefab, transform.position, Quaternion.identity);

            // Set the flag to true to indicate that it has been loaded
            hasLoaded = true;
        }
    }
}
