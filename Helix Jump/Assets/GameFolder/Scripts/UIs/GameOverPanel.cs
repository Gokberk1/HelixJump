using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartButton()
        {
            GameManager.Instance.RestartGame("Level1");
        }

        public void BackToMenuButton()
        {
            GameManager.Instance.BackToMenu();
        }

    }
}

