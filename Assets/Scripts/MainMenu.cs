using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MakeGame()
    {
        SceneManager.LoadScene("MakeGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}