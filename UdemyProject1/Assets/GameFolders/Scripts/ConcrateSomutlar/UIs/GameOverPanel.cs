using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UIs
{

    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void NoButtonClicked()
        {
            GameManager.Instance.LoadMenuScene();
       }
    }


}