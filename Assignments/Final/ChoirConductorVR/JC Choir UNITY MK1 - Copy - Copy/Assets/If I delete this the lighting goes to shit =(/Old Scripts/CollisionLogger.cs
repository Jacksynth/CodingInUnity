using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    // This function is called when the cube collides with another GameObject
    private void OnCollisionEnter()
    {
        // Print the name of the collided object to the debug log
        Debug.Log("Collision");
    }
}
