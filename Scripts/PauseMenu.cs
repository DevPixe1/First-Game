using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuPanel;
    public GameObject pauseButton;
    public GameObject jumpButton;
    public GameObject attackButton;
    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        pauseButton.SetActive(false);
        jumpButton.SetActive(false);
        attackButton.SetActive(false);

        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        pauseButton.SetActive(true);
        jumpButton.SetActive(true);
        attackButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameIsPaused = false;
    } 
}
