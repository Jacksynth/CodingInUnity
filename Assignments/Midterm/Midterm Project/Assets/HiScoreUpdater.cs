using UnityEngine;
using TMPro;

public class HiScoreUpdater : MonoBehaviour
{
    public static HiScoreUpdater Instance;

    public TMP_Text highScoreText;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateHighScoreUI(int highScore)
    {
        if (highScoreText != null)
        {
            highScoreText.text = highScore.ToString();
            Debug.Log("High Score updated: " + highScore);
        }
    }
}
