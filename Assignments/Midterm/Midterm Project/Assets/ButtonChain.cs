using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChain : MonoBehaviour
{
    public string sceneName = "Game"; // The default scene name

    private void OnEnable() 
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Button script activated!");
    }
}
