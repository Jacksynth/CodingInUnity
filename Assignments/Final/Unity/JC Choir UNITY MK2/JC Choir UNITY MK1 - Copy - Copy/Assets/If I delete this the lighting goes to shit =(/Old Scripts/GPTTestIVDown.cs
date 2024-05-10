using UnityEngine;
using FMODUnity;

public class GPTTestIVDown : MonoBehaviour
{
    public EventReference eventReference;
    public float noteValue; // Add this variable to display Note value in the Inspector


    private FMOD.Studio.EventInstance eventInstance;
    private FMOD.Studio.EventDescription eventDescription;
    private FMOD.Studio.PARAMETER_ID noteParameterId;

    private void Start()
    {
        eventDescription = RuntimeManager.GetEventDescription(eventReference);
        eventDescription.getParameterDescriptionByName("Note", out FMOD.Studio.PARAMETER_DESCRIPTION parameterDescription);
        noteParameterId = parameterDescription.id;

        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

 private void Update() // Use Update to constantly update the noteValue
    {
        float currentValue = 0f;
        eventInstance.getParameterByID(noteParameterId, out currentValue);
        noteValue = currentValue;
    }

    private void OnTriggerEnter()
    {
      //  if (other.CompareTag("Player")) // Adjust the tag as needed
      //  {
            float currentValue = 0f;
            eventInstance.getParameterByID(noteParameterId, out currentValue);
 Debug.Log("Triggered: Down");
            // Lower the value of Note by 1
            currentValue -= 1f;

            // If the value goes below 0, set it to 6
            if (currentValue < 0f)
            {
                currentValue = 6f;
            }

            eventInstance.setParameterByID(noteParameterId, currentValue);
      //  }
    }

    private void OnDestroy()
    {
        eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        eventInstance.release();
    }
}
