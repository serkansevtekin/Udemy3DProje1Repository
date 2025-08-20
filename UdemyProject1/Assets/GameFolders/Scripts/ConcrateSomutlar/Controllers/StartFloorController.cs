using System.Collections;
using UnityEngine;

namespace UdemyPorject1.Controllers
{
    /// <summary>
    /// Player nesnesi yukarı yönlü harekete başladı ise 
    /// Start floor kaybolacak
    /// </summary>
    public class StartFloorController : MonoBehaviour
    {
        [Header("Yok Olma Süresi")]
        [SerializeField] float _delaySecond;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="OnCollisionExit">
        /// Nesneye deyme işlemi sonlandı ise bu tetiklenir
        /// örnek: roket başlangıç noktasından ayrılırsa
        /// </param>
        /// 
        /// <param name="other">
        /// çarpışma bilgilerini tutar
        /// </param>
        void OnCollisionExit(Collision other)
        {

            ///<summary>
            /// other.collider → Çarpışma olan collider’ı alıyor.
            ///.GetComponent<PlayerController>() → Bu collider’ın bağlı olduğu GameObject üzerinde PlayerController script’i var mı diye kontrol ediyor.
            /// Eğer varsa → script component’i player değişkenine atanıyor
            /// Eğer yoksa → player değişkeni null oluyor.
            /// </summary>
            PlayerController player = other.collider.GetComponent<PlayerController>();

            ///<remarks>
            /// player değişkeni null değil ise.

            /// </remarks>
            if (player != null)
            {
                ///<remarks>
                /// StartCoroutine() - Coroutine’i çalıştırır
                /// </remarks>
                StartCoroutine(StartFloorDestroyAfterSeconds(_delaySecond));
            }


        }
        /// <summary>
        ///  IEnumerator - Adım adım çalışabilen metod, yield return ile kontrol edilir
        /// yield return - Coroutine’in bekleme veya bir sonraki adıma geçme noktası
        /// WaitForSeconds(delaySecond) - verilen saniye kadar bekle ve sonra sonraki işlemleri yap
        /// Destroy() => obje yoketmek için kullanılır.
        /// this.gameObject => şuanda script'in bulunduğu obje anlamına geliyor.
        /// </summary>
        /// <param name="delaySecond"> Editörden aldığımız yok etme saniyesi</param>

        private IEnumerator StartFloorDestroyAfterSeconds(float delaySecond)
        {

            yield return new WaitForSeconds(delaySecond);
            Destroy(this.gameObject);
        }
    }


}