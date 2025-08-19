using UdemyPorject1.Controllers;
using UnityEngine;

namespace UdemyPorject1.Movement
{

    public class Mover
    {
        Rigidbody _rigidBody;
        PlayerController _playerController;
        Fuel _fuel;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidBody = _playerController.GetComponent<Rigidbody>();
            _fuel = _playerController.GetComponent<Fuel>();
        }


        public void FixedTick(bool isForceUp)
        {

            if (isForceUp)
            {
                _rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.ForceSpeed); //Pozisyonumuza göre force veriyor
                _fuel.FuelDecrease(0.2f);
            }
        }

    }
}

