using UnityEngine;
using FMODUnity;

public class GTPTestIII : MonoBehaviour
{
    public StudioEventEmitter eventEmitter;
    public Collider cubeCollider;
    public Collider cylinderCollider;

    private float note1Value = 9;

    private void OnTriggerEnter(Collider other)
    {
        if (other == cubeCollider)
        {
            note1Value = Mathf.Max(note1Value - 1, 6);
            UpdateNote1Parameter();
        }
        else if (other == cylinderCollider)
        {
            note1Value = Mathf.Min(note1Value + 1, 14);
            UpdateNote1Parameter();
        }
    }

    private void UpdateNote1Parameter()
    {
        if (eventEmitter)
        {
            eventEmitter.SetParameter("Note1", note1Value);
        }
    }
}
