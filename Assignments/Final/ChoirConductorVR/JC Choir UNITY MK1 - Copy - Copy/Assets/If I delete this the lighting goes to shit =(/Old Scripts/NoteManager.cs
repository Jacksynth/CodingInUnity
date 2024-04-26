using UnityEngine;
using FMODUnity;

public class NoteManager : MonoBehaviour
{
    public StudioEventEmitter eventEmitter;
    public Collider cubeCollider;
    public Collider cylinderCollider;

    private int noteValue = 9;
    private const int minValue = 6;
    private const int maxValue = 14;

    private void OnTriggerEnter(Collider other)
    {
        if (other == cubeCollider)
        {
            noteValue = Mathf.Max(minValue, noteValue - 1);
            UpdateNoteValue();
        }
        else if (other == cylinderCollider)
        {
            noteValue = Mathf.Min(maxValue, noteValue + 1);
            UpdateNoteValue();
        }
    }

    private void UpdateNoteValue()
    {
        // Update the FMOD parameter "Note1" with the new noteValue
        if (eventEmitter != null && eventEmitter.EventInstance.isValid())
        {
            eventEmitter.EventInstance.setParameterByName("Note1", noteValue);
        }
    }
}
