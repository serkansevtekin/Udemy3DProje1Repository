using UdemyPorject1.Controllers;
using UnityEngine;

namespace UdemyPorject1.Movement
{

    /// <summary>
    /// /// Roketin dönme işlemlerini yönetmek için kullanılan sınıf.
    /// Rigidbody ve PlayerController referanslarını içerir.
    /// SOLI Prensiplere göre sorumluluklar ayrılmıştır.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))] //Bu Scriptin bulunduğu gameObje nesenesinde rigidbody bulunmak zorunda
    public class Rotator
    {

        Rigidbody _rigidbody;
        PlayerController _playerController;

        /// <summary>
        /// Rotator sınıfını başlatır ve gerekli componentleri alır
        /// </summary>
        /// <param name="playerController">Roketi kontroll eden PlayerController  instance</param>
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }


        /// <summary>
        /// Roketin dönüşünü yönetir
        /// Rigidbody ile fizik motorunun uyumlu bir şekilde dönmesini sağlar
        /// Tuşa basılmadığında fizik motorunun kendi dönüşüne izin verir.
        /// </summary>
        /// <param name="direction"> -1 = sol veya 1 = sağ , 0 = dönme yok </param>
        /// <param name="isForceUp"> 
        /// Roket ileri duğru hareket ediyor mu? (true = ileri hareket ediyor, false = duruyor)
        /// </param>
        public void FixedTick(float direction, bool isForceUp)
        {
            // Tuş yoksa fizik motorunun kendi dönüşüne izin ver
            if (direction == 0 || !isForceUp)
            {
                if (_rigidbody.freezeRotation)
                {
                    _rigidbody.freezeRotation = false;

                }
                return;
            }
            // Roket ileri gidiyorsa fizik motorunun kendi dönüşünü engelle
            if (!_rigidbody.freezeRotation)
            {
                _rigidbody.freezeRotation = true;
            }
            if (isForceUp)
            {
                //fizik motoru ile döndürme
                Quaternion turnOffset = Quaternion.Euler(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
                _rigidbody.MoveRotation(_rigidbody.rotation * turnOffset);


                //Fizik motoru kullanmadan trasnform ile dödürme
                //  _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
            }
        }

    }

}