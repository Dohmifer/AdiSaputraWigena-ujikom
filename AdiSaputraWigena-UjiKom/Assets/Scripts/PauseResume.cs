using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{
    public Button pauseButton;
    public Button ResumeButton;
    public Button mainMenu;
    private bool isPause = false;
    void Start()
    {
        pauseButton.gameObject.SetActive(true);
        ResumeButton.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            TogglePause();
        }

    }
    public void PauseClick()
    {
        Time.timeScale = 0f;
        pauseButton.gameObject.SetActive(false);
        ResumeButton.gameObject.SetActive(true);
        isPause = true;
    }
    public void ResumeClick()
    {
        Time.timeScale = 1f;
        pauseButton.gameObject.SetActive(true);
        ResumeButton.gameObject.SetActive(false);
        isPause = false;
    }

    public void TogglePause()
    {
        if (isPause)
        {
            ResumeClick();
            mainMenu.gameObject.SetActive(true);
        }
        else
        {
            PauseClick();
            mainMenu.gameObject.SetActive(false);
        }

    }

    public void MainMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
