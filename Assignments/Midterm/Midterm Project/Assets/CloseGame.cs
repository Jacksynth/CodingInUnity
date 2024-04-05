using UnityEngine;

public class CloseGame : MonoBehaviour
{
    private void OnEnable() 
    {
            Application.Quit();
            Debug.Log("CloseGame script activated!");

        }
    }
