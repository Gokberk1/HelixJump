using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.UIs
{
    public class GamePlayCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;
        [SerializeField] GamePlayPanel _gamePlayPanel;

        private void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
            _gamePlayPanel.gameObject.SetActive(true);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;
        }

        private void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
            _gamePlayPanel.gameObject.SetActive(false);
        }
    }
}



