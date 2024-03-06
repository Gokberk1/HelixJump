using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : SingletonThisObject<GameManager>
{
    private int _score;
    [SerializeField] TextMeshProUGUI _scoreText;

    private void Awake()
    {
        SingletonIt(this);
    }

    public void AddScore(int ringScore)
    {
        _score += ringScore;
        _scoreText.text = _score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
