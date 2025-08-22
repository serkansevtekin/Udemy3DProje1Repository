using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UIs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        void Awake()
        {
            if (_gameOverPanel.activeSelf)//game obje açıksa yada hiearchy de aktif se
            {
                _gameOverPanel.SetActive(false);
            }
        }

        void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }


        void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;

        }
        
        private void HandleOnGameOver() {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true); 
                
            }
        }

    }


}