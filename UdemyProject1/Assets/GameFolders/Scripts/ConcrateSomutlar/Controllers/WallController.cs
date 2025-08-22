using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyPorject1.Controllers
{
    public class WallController : MonoBehaviour
    {   
        //Unity çarpışma konrolü metodu
        void OnCollisionEnter(Collision other)
        {
             ///<summary>
            /// other.collider → Çarpışma olan collider’ı alıyor.
            ///.GetComponent<PlayerController>() → Bu collider’ın bağlı olduğu GameObject üzerinde PlayerController script’i var mı diye kontrol ediyor.
            /// Eğer varsa → script component’i player değişkenine atanıyor
            /// Eğer yoksa → player değişkeni null oluyor.
            /// </summary>
            PlayerController playerController = other.collider.GetComponent<PlayerController>();

            //Çarptığımız nesene oyuncu nesnesimi diye kontrol ediyoruz. 
            //Çünkü sadece PlayerController scripti olan nesneler “oyuncu” kabul ediliyor.
            if (playerController != null && playerController.CanMove)
            {
                //Eğer oyuncuyla çarpıştıysa, sahneyi baştan yükle
                //SceneManager.GetActiveScene().buildIndex => Şu anki sahnenin build index numarasını al
                //SceneManager.LoadScene() => sahneyi yeniden açar
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
                GameManager.Instance.GameOver();
            }
        }
    }

}