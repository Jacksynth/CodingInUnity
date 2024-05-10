/*using UnityEngine;
using TMPro;
using FMODUnity;
using FMOD.Studio;

public class NoteNameUpdater : MonoBehaviour
{
    [SerializeField]
    private StudioEventEmitter eventEmitter; // Reference to the game object with FMOD StudioEventEmitter component

    private TMP_Text tmpTextComponent; // Reference to the TMP Text component

    // Array of strings to map with FMOD "Note" values
    public string[] noteTexts = { "C", "D", "E", "F", "G", "A", "B" };

    void Start()
    {
        // Get the TMP Text component attached to the same GameObject
        tmpTextComponent = GetComponentInChildren<TMP_Text>();

        // Check if TMP Text component exists
        if (tmpTextComponent != null)
        {
            // Check if eventEmitter is assigned
            if (eventEmitter != null)
            {
                // Get the FMOD Event Description associated with the StudioEventEmitter
                EventDescription eventDescription = eventEmitter.EventDescription;

                // Check if the eventDescription is valid
                if (eventDescription.isValid())
                {
                    // Get the parameter description of the "Note" parameter
                    PARAMETER_DESCRIPTION noteParamDesc;
                    eventDescription.getParameterDescriptionByName("Note", out noteParamDesc);

                    // Get the FMOD Event Instance associated with the StudioEventEmitter
                    EventInstance eventInstance = eventEmitter.EventInstance;

                    // Declare a variable to store the parameter value
                    float noteValue = 0f;

                    // Get the value of the "Note" parameter
                    eventInstance.getParameterValue(noteParamDesc.id, out noteValue);

                    // Convert the noteValue to an integer to use as an index for the noteTexts array
                    int index = Mathf.RoundToInt(noteValue) % noteTexts.Length;

                    // Ensure that the index is within the bounds of the noteTexts array
                    if (index >= 0 && index < noteTexts.Length)
                    {
                        // Set the text of the TMP Text component to the value from the noteTexts array
                        tmpTextComponent.text = noteTexts[index];
                    }
                    else
                    {
                        Debug.LogError("Index out of bounds for noteTexts array.");
                    }
                }
                else
                {
                    Debug.LogError("Invalid Event Description.");
                }
            }
            else
            {
                Debug.LogError("Event Emitter is not assigned.");
            }
        }
        else
        {
            Debug.LogError("TMP Text component not found on the same GameObject.");
        }
    }
}
*/