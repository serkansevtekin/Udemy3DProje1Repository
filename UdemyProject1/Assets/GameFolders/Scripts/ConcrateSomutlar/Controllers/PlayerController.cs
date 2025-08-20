using UdemyPorject1.Movement;
using UdemyProject1.Inputs;
using UnityEngine;

namespace UdemyPorject1.Controllers
{

    public class PlayerController : MonoBehaviour
    {


        [SerializeField] float _forceSpeed = 55f;
        [SerializeField] float _turnSpeed = 10f;


        Mover _mover;
        Rotator _rotator;
        DefaultInput _defaultInput;
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;
        public float TurnSpeed => _turnSpeed;
        public float ForceSpeed => _forceSpeed;


        private void Awake()
        {

            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        void Update()
        {
            //input - klavye basışları
            if (_defaultInput.IsForceUp && !_fuel.IsEmpty)
            {

                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }

            _leftRight = _defaultInput.LeftRight;

        }

        private void FixedUpdate()
        {
            // fizik işlemleri
            _mover.FixedTick(isForceUp: _canForceUp);

            _rotator.FixedTick(direction: _leftRight, isForceUp: _canForceUp);
        }
    }

}

