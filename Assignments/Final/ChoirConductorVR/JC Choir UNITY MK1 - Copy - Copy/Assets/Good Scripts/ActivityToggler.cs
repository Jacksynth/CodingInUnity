using UnityEngine;

public class ActivityToggler : MonoBehaviour
{
    public GameObject[] targetObjects; // Assign the target GameObjects in the Inspector

    private void OnTriggerEnter()
    {
        ToggleActivities();
    }

    private void ToggleActivities()
    {
        foreach (GameObject obj in targetObjects)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
}
