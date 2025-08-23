using System.Collections;
using UdemyPorject1.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {

            SingletonThisGameObject(this);
           
        }



        /// <summary>
        /// OnGameOver → senin event’in.
        ///!= null → bu event’e bir şey abone olmuş mu diye kontrol ediyoruz.
        ///.Invoke() → event’i tetikliyor (çalıştırıyor).
        /// </summary>
        public void GameOver()
        {
            if (OnGameOver != null) //kısa yazımı -> OnGameOver?.Invoke();
            {

                OnGameOver.Invoke();//Eventi tetikle

            }

            if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                Debug.Log("Son Sahne");
                
            }
            

        }


        public void MissionSucced()
        {
            if (OnMissionSucced != null)
            {
                OnMissionSucced.Invoke();

            }

         if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                Debug.Log("Son Sahne");
                
            }
            

        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelScreneAsync(levelIndex));
        }

        private IEnumerator LoadLevelScreneAsync(int levelIndexNo)
        {
            SoundManager.Instance.StopSound(1);

            int nexSceneIndex = SceneManager.GetActiveScene().buildIndex + levelIndexNo;
    
            yield return SceneManager.LoadSceneAsync(nexSceneIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }


        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }

}