using UnityEngine;
using FMODUnity;
using TMPro;

public class GPTTestVDown : MonoBehaviour
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
            index = Mathf.RoundToInt(newValue) % noteNames.Length;
            tmpTextToUpdate.text = noteNames[index];

        }
    }
}

