using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainmenuController : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _setting;
    [SerializeField] private Button _controllerInfo;
    [SerializeField] private Button _exit;

    [SerializeField] private string _playScene;
    [SerializeField] private string _settingScene;
    [SerializeField] private string _controllerInfoScene;

    private void Start()
    {
        _play.onClick.AddListener(PlayButton);
        _controllerInfo.onClick.AddListener(ControllerInfoButton);
        _exit.onClick.AddListener(ExitButton);
    }

    private void PlayButton()
    {
        SceneManager.LoadScene(_playScene);

    }

    private void SettingButton()
    {
        SceneManager.LoadScene(_settingScene);

    }

    private void ControllerInfoButton()
    {
        // Load the controller info scene
        SceneManager.LoadScene(_controllerInfoScene);

    }

    private void ExitButton()
    {
        Application.Quit();

    }
}
