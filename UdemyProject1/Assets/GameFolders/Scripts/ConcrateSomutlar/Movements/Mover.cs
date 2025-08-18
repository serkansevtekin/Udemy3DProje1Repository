using UnityEngine;

namespace UdemyPorject1.Movement
{

    public class Mover
    {
        Rigidbody _rigidBody;
      
    public Mover(Rigidbody rigidbody)
          {
              _rigidBody = rigidbody;
             
          }


        public void FixedTick(bool isForceUp,float forceSpeed)
        {
           
            if (isForceUp)
            {
                _rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * forceSpeed); //Pozisyonumuza göre force veriyor
            }
        }

    }
}

