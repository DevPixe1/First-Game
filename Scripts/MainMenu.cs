using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject ConfirmationPanel;


    public void OptionsMenu()
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }
    public void BackToMain()
    {
        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResertHighScore()
    {
        ConfirmationPanel.SetActive(true);
    }
    public void ConfirmReset()
    {
        PlayerPrefs.SetFloat("highScore", 0);
        ConfirmationPanel.SetActive(false);
    }
    public void ConfirmCancel()
    {
        ConfirmationPanel.SetActive(false);
    }
}
