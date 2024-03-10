using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace HelixJump.UIs
{
    public class GamePlayPanel : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _scoreText;

        private void Update()
        {
            _scoreText.text = GameManager.Instance._score.ToString();
        }
    }
}

