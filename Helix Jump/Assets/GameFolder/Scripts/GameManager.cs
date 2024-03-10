using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : SingletonThisObject<GameManager>
{
    public int _score = 0;
    public event System.Action OnGameStop;

    private void Awake()
    {
        SingletonIt(this);
    }

    public void StopGame()
    {
        Time.timeScale = 0f;

        if (OnGameStop != null)
        {
            OnGameStop();
        }
        OnGameStop?.Invoke();
    }

    public void AddScore(int ringScore)
    {
        _score += ringScore;
    }

    public void RestartGame(string sceenName)
    {
        SceneManager.LoadScene(sceenName);
        _score = 0;
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
