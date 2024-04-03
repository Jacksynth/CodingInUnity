using UnityEngine;
using FMODUnity;

public class GPTTestVUp : MonoBehaviour
{
    [SerializeField]
    private StudioEventEmitter eventEmitter;

    private void OnTriggerEnter(Collider other)
    {
       
            IncreaseNoteValue();
        
    }

   
   private void IncreaseNoteValue()
    {
        if (eventEmitter != null)
        {
            float currentValue = 0;
            eventEmitter.EventInstance.getParameterByName("Note", out currentValue);

            // Increase the value and wrap it around from 21 to 14
            int newValue = Mathf.Min(Mathf.FloorToInt(currentValue) + 1, 21);
            if (newValue == 21)
            {
                newValue = 14;
            }

            eventEmitter.EventInstance.setParameterByName("Note", newValue);
        }
    }
}
