using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditScene;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditScene.onClick.AddListener(CreditScene);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

}
