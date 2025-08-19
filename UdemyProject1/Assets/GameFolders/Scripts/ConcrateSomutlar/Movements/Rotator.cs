using UdemyPorject1.Controllers;
using UnityEngine;

namespace UdemyPorject1.Movement
{
    public class Rotator
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction, bool isForceUp)
        {
            if (direction == 0)
            {
                if (_rigidbody.freezeRotation)
                {
                    _rigidbody.freezeRotation = false;

                }
                return;
            }
            if (!_rigidbody.freezeRotation)
            {
                _rigidbody.freezeRotation = true;
            }
          if (isForceUp)
          {
              _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
          }
        }

    }

}