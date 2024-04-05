using UnityEngine;

public class DestroyDupe : MonoBehaviour
{
    void Awake()
    {
        GameObject[] existingObjects = GameObject.FindGameObjectsWithTag(gameObject.tag);

        foreach (GameObject obj in existingObjects)
        {
            if (obj.name == gameObject.name && obj != gameObject)
            {
                // Destroy the new object if a match is found
                Destroy(gameObject);
                Debug.Log("Destroyed self");
                return;
            }
        }
    }
}
