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

        bool _isForceUp;
        float _leftRight;
        public float TurnSpeed => _turnSpeed;
        public float ForceSpeed => _forceSpeed;
        private void Awake()
        {

            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
        }
        void Update()
        {
            //input - klavye basışları
            if (_defaultInput.IsForceUp)
            {

                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

            _leftRight = _defaultInput.LeftRight;

        }

        private void FixedUpdate()
        {
            // fizik işlemleri
            _mover.FixedTick(isForceUp: _isForceUp);

            _rotator.FixedTick(_leftRight,isForceUp:_isForceUp);
        }
    }

}

