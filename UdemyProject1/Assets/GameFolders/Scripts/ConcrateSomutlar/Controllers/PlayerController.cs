using UdemyPorject1.Movement;
using UdemyProject1.Inputs;
using UnityEngine;

namespace UdemyPorject1.Controllers
{

    public class PlayerController : MonoBehaviour
    {


        [SerializeField] float _forecSpeed = 55;
        Mover _mover;
        DefaultInput _defaultInput;

        bool _isForceUp;
        private void Awake()
        {

            _defaultInput = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());

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

        }

        private void FixedUpdate()
        {
            // fizik işlemleri
            _mover.FixedTick(isForceUp: _isForceUp, forceSpeed: _forecSpeed);
        }
    }

}

