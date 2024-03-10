using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HelixJump.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void PlayGame()
        {
            GameManager.Instance.RestartGame("Level1");
        }

        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
    }
}

