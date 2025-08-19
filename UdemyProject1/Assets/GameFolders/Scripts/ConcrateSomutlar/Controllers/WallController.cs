using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyPorject1.Controllers
{
    public class WallController : MonoBehaviour
    {
        void OnCollisionEnter(Collision other)
        {
            PlayerController playerController = other.collider.GetComponent<PlayerController>();

            if (playerController != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

}