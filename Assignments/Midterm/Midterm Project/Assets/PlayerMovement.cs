using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Get the position of the mouse cursor in world space
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = 0f; // Make sure the z-coordinate is 0

        // Keep the triangle within the bounds of the screen
        Vector3 newPosition = transform.position;

        // Get the screen boundaries
        float screenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        float screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        float screenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        float screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        // Clamp the cursor position to the screen boundaries
        newPosition.x = Mathf.Clamp(cursorPosition.x, screenLeft, screenRight);
        newPosition.y = Mathf.Clamp(cursorPosition.y, screenBottom, screenTop);

        // Move the triangle to the clamped position
        transform.position = newPosition;
    }
}

//I found some code online that i spruced up a bit.