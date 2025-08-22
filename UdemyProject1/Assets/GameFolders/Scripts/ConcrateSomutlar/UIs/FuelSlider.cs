using UdemyPorject1.Movement;

using UnityEngine;
using UnityEngine.UI;

namespace UdemyProject1.UIs
{
    public class FuelSlider : MonoBehaviour
    {
        GameObject _playerObj;
        Fuel _fuel;
        Slider _slider;

        void Awake()
        {
            _slider = GetComponent<Slider>();
            _playerObj = GameObject.FindWithTag("Player");

            if (_playerObj != null)
            {
                _fuel = _playerObj.GetComponent<Fuel>();
            }
            else
            {
                Debug.Log("Sahnede Player tag ile bir obje yok");
            }
         
        }
        void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }

    }
    
}
