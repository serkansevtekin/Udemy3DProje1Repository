using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyPorject1.Controllers
{
    public class WallController : MonoBehaviour
    {   
        //Unity çarpışma konrolü metodu
        void OnCollisionEnter(Collision other)
        {
            // Çarpışılan nesenenin coliderini alıyoruz => = other.collider.GetComponent<PlayerController>();
            // Sonra o colider'ın bağlı olduğu GameObject'te PlayerController SCRİPT varmı diye bakıyor => PlayerController playerController =
            //Eğer varsa playerController değişkene atıyor. Yok ise " null " döndürüyor
            PlayerController playerController = other.collider.GetComponent<PlayerController>();

            //Çarptığımız nesene oyuncu nesnesimi diye kontrol ediyoruz. 
            //Çünkü sadece PlayerController scripti olan nesneler “oyuncu” kabul ediliyor.
            if (playerController != null)
            {
                //Eğer oyuncuyla çarpıştıysa, sahneyi baştan yükle
                //SceneManager.GetActiveScene().buildIndex => Şu anki sahnenin build index numarasını al
                //SceneManager.LoadScene() => sahneyi yeniden açar
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
            }
        }
    }

}