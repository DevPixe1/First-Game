using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 1f;
    public float gameSpeedIncrease;
    public float maxGameSpeed;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private float score;
    public float gameSpeed {  get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(Instance == this)
        {
            Instance = null;
        }
    }
    void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        gameSpeed = initialGameSpeed;
        score = 0f;
        UpdateHighScore();
    }

    private void Update()
    {
        if (gameSpeed<20)
        {
            gameSpeed += gameSpeedIncrease * Time.deltaTime;
        }
        else
        {
            gameSpeed = maxGameSpeed;
        }

        score += gameSpeed * Time.deltaTime;
        scoreText.text = score.ToString();
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");

        UpdateHighScore();
    }
    private void UpdateHighScore()
    {
        float highScore = PlayerPrefs.GetFloat("highScore", 0);

        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("highScore", highScore);
        }
        highScoreText.text = Mathf.FloorToInt(highScore).ToString("D5");

    }
}
