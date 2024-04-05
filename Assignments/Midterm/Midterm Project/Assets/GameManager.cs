using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Initialization
    public static GameManager instance;
    public GameObject ObstA; 
    public GameObject ObstB; 
    public GameObject ObstC; 
    public GameObject ObstD; 
    public GameObject ObstE;
    public GameObject PowerUpPrefab; 
    
    [SerializeField]
    private static int _score = 0;

    // Property to expose the score in the Inspector
    public static int Score
    {
        get { return _score; }
        set { _score = value; } // Make the set accessor public
    }
    
    [SerializeField]
    private static float _powerup = 1.0f;

    // Property to expose the score in the Inspector
    public static float PowerUp
    {
        get { return _powerup; }
        set { _powerup = value; } // Make the set accessor public
    }
    
    [SerializeField]
    private static int _pupu;

    // Property to expose the score in the Inspector
    public static int PointsUntillPowerUp
    {
        get { return _pupu; }
        set { _pupu = value; } // Make the set accessor public
    }
    
    public static int GameState = 1;
    float GameSpeed; // determines velocity for powerups and obstacles as well as spawn rate for both
    float ObstacleTimer; 
    public TextMeshProUGUI ScoreText;

    void Awake()
    {
        instance = this;
        ObstacleTimer = 1;
        Score = 0;
        _score = 0;
        GameState = 1;
        Time.timeScale = 1;
        StartCoroutine(SpawnObstacles());
        StartCoroutine(SpawnPowerUps());

    }

    IEnumerator SpawnObstacles()
    {
        while (GameState == 1)
        {
            yield return new WaitForSeconds(ObstacleTimer);
            float ObstXOffset = Random.Range(-1.5f, 1.5f);
            // Spawn an obstacle
            GameObject ObstInstance = null;
            if (Score >= 0 && Score < 10)
            {
                ObstInstance = Instantiate(ObstA, new Vector3(ObstXOffset, -6f, 0f), Quaternion.identity);
            }
            else if (Score >= 10 && Score < 20)
            {
                ObstInstance = Instantiate(ObstB, new Vector3(ObstXOffset, -6f, 0f), Quaternion.identity);
            }
            else if (Score >= 20 && Score < 30)
            {
                ObstInstance = Instantiate(ObstC, new Vector3(ObstXOffset, -6f, 0f), Quaternion.identity);
            }
            else if (Score >= 30 && Score < 40)
            {
                ObstInstance = Instantiate(ObstD, new Vector3(ObstXOffset, -6f, 0f), Quaternion.identity);
            }
            else if (Score >= 40)
            {
                ObstInstance = Instantiate(ObstE, new Vector3(ObstXOffset, -6f, 0f), Quaternion.identity);
            }
            
            if (ObstInstance != null)
            {
                Rigidbody2D rb = ObstInstance.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    GameSpeed = (5f + (Score / 5f)) * PowerUp; // Recalculate GameSpeed
                    ObstacleTimer = 5 / (GameSpeed * Random.Range(0.75f, 1.25f)); // Recalculate ObstacleTimer
                    rb.velocity = new Vector2(0f, GameSpeed); // Set velocity in the positive Y direction
                }
            }
        }
    }
    IEnumerator SpawnPowerUps()
    {
        while (GameState == 1 && PowerUp == 1 && PointsUntillPowerUp == 0)
        {
            yield return new WaitForSeconds(Random.Range(10, 20)); // Wait for a random interval
            float PowerUpXOffset = Random.Range(-1.8f, 1.8f);
            
            // Spawn a powerup
            GameObject PowerUpInstance = Instantiate(PowerUpPrefab, new Vector3(PowerUpXOffset, -6f, 0f), Quaternion.identity);
            Rigidbody2D rb = PowerUpInstance.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                GameSpeed = (5f + (Score / 5f)) * PowerUp; // Recalculate GameSpeed
                rb.velocity = new Vector2(0f, GameSpeed); // Set velocity in the positive Y direction
            }
        }
    }

        void Update()
{
        // Update the TMP text with the current score value
        ScoreText.text = "Score: " + Score.ToString();
          if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Change scene to a new scene (assigned in the inspector)
            SceneManager.LoadScene("Main Menu");
            Debug.Log("Menu triggered!");

        }
    }

    // Method to update the score
public void UpdateScore(int newScore)
{
    Score = newScore;
    Debug.Log("Score updated: " + Score);
    ////// GGGGGGGGGGGG
    Memory.Instance.UpdateHighScore(newScore);

}
 public void ChangeGameState(int newState)
    {
        GameState = newState;
        if (newState == 0)
        {
            // Update the score when GameState is set to 0
            UpdateScore(Score); // Reset score to 0 or any other desired value
        }
    }


}


