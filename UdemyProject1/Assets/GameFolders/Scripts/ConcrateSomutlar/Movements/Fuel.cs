using UnityEngine;

namespace UdemyPorject1.Movement
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField , Tooltip("Mevcut yakıt miktarı (Sadece debug için)")] float _currentFuel;

        [SerializeField] ParticleSystem _particleRocketFire;

        public bool IsEmpty => _currentFuel < 1f;
        void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)// increase => artış
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if (_particleRocketFire.isPlaying)
            {
                _particleRocketFire.Stop();
            }
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);
           
            if (_particleRocketFire.isStopped)
            {
                _particleRocketFire.Play();

            }
        }
    }

}
