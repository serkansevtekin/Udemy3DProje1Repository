using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyPorject1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {

        [SerializeField] GameObject _finishFloorFirework;
        [SerializeField] GameObject _finishFloorLight;

        void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove)
            {
                return;
            }
            if (other.GetContact(0).normal.y == -1) // Tependen değip deymediğini kontroll edioruz
            {
                _finishFloorFirework.gameObject.SetActive(true);
                _finishFloorLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();

            }
            else
            {
                //GameOver
                GameManager.Instance.GameOver();
            }
        }
    }

    
}