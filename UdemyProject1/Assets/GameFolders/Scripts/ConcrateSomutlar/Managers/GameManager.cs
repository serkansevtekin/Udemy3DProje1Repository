using UnityEngine;

namespace UdemyProject1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public static GameManager Instance { get; private set; }//Instance - örneğini al demek

        private void Awake()
        {

            SingeltonThisGameObject();
        }

        private void SingeltonThisGameObject()
        {
            //daha önce hiç oluşmamışsa oluştur (Tekil oluyor)
            if (Instance == null)
            {
                Instance = this;// bu ilk oluşan game managerin referansını bu instance ata
                DontDestroyOnLoad(this.gameObject);// sahne geçişlerinde bunu yok etme
            }
            else
            {
                //aynı gameManager den 2,3,4... tane oluşmaya çalışırsa yok et
                Destroy(this.gameObject);
            }
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

        }
    }

}