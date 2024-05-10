using UnityEngine;

public class NoteValueUpdater : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string fmodEvent; // Name of your FMOD event, e.g., "event:/CmajAm"

    public GameObject cube; // Assign the Cube GameObject in the Inspector
    public GameObject cylinder; // Assign the Cylinder GameObject in the Inspector

    private FMOD.Studio.EventInstance fmodInstance;
    private FMOD.Studio.EventDescription eventDescription;
    private FMOD.Studio.PARAMETER_ID note1ParameterId;

    [Range(0, 20)] // Add this attribute to show "Note1" in the Inspector
    public int currentNoteValue;

    private int minNoteValue = 6;
    private int maxNoteValue = 14;

    void Start()
    {
        fmodInstance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        fmodInstance.start();

        eventDescription = FMODUnity.RuntimeManager.GetEventDescription(fmodEvent);
        eventDescription.getParameterDescriptionByName("Note1", out FMOD.Studio.PARAMETER_DESCRIPTION parameterDescription);
        note1ParameterId = parameterDescription.id;

        // Set the initial value of "Note1" to 9.
        fmodInstance.setParameterByName("Note1", 9);
        UpdateNoteValue(); // Update the currentNoteValue variable for display in the Inspector
    }

    private void UpdateNoteValue()
    {
        fmodInstance.getParameterByID(note1ParameterId, out float currentValue);
        currentNoteValue = Mathf.RoundToInt(currentValue);
    }

    private void UpdateNoteValue(int changeValue)
    {
        fmodInstance.getParameterByID(note1ParameterId, out float currentValue);
        int newValue = Mathf.Clamp(Mathf.RoundToInt(currentValue) + changeValue, minNoteValue, maxNoteValue);
        fmodInstance.setParameterByName("Note1", newValue);
        UpdateNoteValue(); // Update the currentNoteValue variable for display in the Inspector
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cube)
        {
            // Play the FMOD event when the cube is triggered
            fmodInstance.start();
            Debug.Log("Cube Triggered. Note1: " + currentNoteValue);
        }
        else if (other.gameObject == cylinder)
        {
            // Play the FMOD event when the cylinder is triggered
            fmodInstance.start();
            Debug.Log("Cylinder Triggered. Note1: " + currentNoteValue);
        }
    }

    void OnDestroy()
    {
        fmodInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        fmodInstance.release();
    }
}
