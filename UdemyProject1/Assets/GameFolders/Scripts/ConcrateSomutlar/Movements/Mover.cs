using UdemyPorject1.Controllers;
using UnityEngine;

namespace UdemyPorject1.Movement
{

    public class Mover
    {
        Rigidbody _rigidBody;
        PlayerController _playerController;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidBody = _playerController.GetComponent<Rigidbody>();

        }


        public void FixedTick(bool isForceUp)
        {

            if (isForceUp)
            {
                _rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.ForceSpeed); //Pozisyonumuza göre force veriyor
            }
        }

    }
}

