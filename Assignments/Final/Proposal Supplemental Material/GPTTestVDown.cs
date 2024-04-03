using UnityEngine;
using FMODUnity;

public class GPTTestVDown : MonoBehaviour
{
    [SerializeField]
    private StudioEventEmitter eventEmitter;

    private void OnTriggerEnter(Collider other)
    {
       
            DecreaseNoteValue();
        
    }

   
    private void DecreaseNoteValue()
    {
        if (eventEmitter != null)
        {
            float currentValue = 0;
            eventEmitter.EventInstance.getParameterByName("Note", out currentValue);

            // Decrease the value and wrap it around from 0 to 6
            int newValue = Mathf.Max(Mathf.FloorToInt(currentValue) - 1, -1);
            if (newValue == -1)
            {
                newValue = 6;
            }

            eventEmitter.EventInstance.setParameterByName("Note", newValue);
        }
    }
}

