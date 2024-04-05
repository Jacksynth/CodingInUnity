using UnityEngine;

public class ToggleAudioListener : MonoBehaviour
{
    public GameObject audioListenerObject; // Drag the GameObject with AudioListener here in the Inspector

    private AudioListener audioListener;

    void Start()
    {
        audioListener = audioListenerObject.GetComponent<AudioListener>();
        if (audioListener == null)
        {
            Debug.LogError("No AudioListener found on the provided GameObject.");
            enabled = false; // Disable the script if AudioListener is not found
        }
    }

    void OnEnable()
    {
        if (audioListener != null)
        {
            audioListener.enabled = true; // Enable the AudioListener when this GameObject is enabled
        }
    }

    void OnDisable()
    {
        if (audioListener != null)
        {
            audioListener.enabled = false; // Disable the AudioListener when this GameObject is disabled
        }
    }
}
