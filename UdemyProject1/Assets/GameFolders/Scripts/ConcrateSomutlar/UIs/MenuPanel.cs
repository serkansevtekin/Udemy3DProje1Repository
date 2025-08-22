using UdemyProject1.Managers;
using UnityEngine;



namespace UdemyProject1.UIs
{
    public class MenuPanel : MonoBehaviour
    {

        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClicked()
        {
            GameManager.Instance.Exit(); 
        }
    }
}

