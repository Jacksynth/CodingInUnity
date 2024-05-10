using UnityEngine;
using FMODUnity;
using TMPro;

public class GPTTestVUp : MonoBehaviour
{
    [SerializeField]
    private StudioEventEmitter eventEmitter;

    [SerializeField]
    private TMP_Text tmpTextToUpdate;

    private string[] noteNames = { "A", "B", "C", "D", "E", "F", "G" };
    // in the future ill have 12 different arrays for each key and ill use a similar array system to pick the set (an array of arrays)
    int index = 0;

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
            index = Mathf.RoundToInt(newValue) % noteNames.Length;
            tmpTextToUpdate.text = noteNames[index];

        }
    }
}
