using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Memory : MonoBehaviour
{
    private static Memory instance;
    private int highScore;

    void Awake() 
    {
        highScore = 0;
        DontDestroyOnLoad(gameObject); // Make sure the Memory object persists between scenes
        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to the sceneLoaded event
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from the sceneLoaded event to prevent memory leaks
    }

    public static Memory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Memory>();
                if (instance == null)
                {
                    GameObject memoryGameObject = new GameObject("Memory");
                    instance = memoryGameObject.AddComponent<Memory>();
                }
            }
            return instance;
        }
    }

    public int HighScore
    {
        get { return highScore; }
    }

    // Make UpdateHighScore method accessible from outside
    public void UpdateHighScore(int newScore)
    {
        if (newScore > highScore)
        {
            highScore = newScore;
            HiScoreUpdater.Instance.UpdateHighScoreUI(highScore);
            Debug.Log("HS Updated!");
        }
    }

    // Called when a new scene is loaded
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        TMP_Text highScoreText = FindObjectOfType<TMP_Text>(); // Find the TMP text element in the scene
        if (highScoreText != null)
        {
            // Update the high score UI with the current high score
            highScoreText.text = highScore.ToString();
        }
    }
}
