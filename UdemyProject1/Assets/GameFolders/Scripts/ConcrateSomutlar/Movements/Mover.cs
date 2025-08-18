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


        public void FixedTick(bool isForceUp)
        {
           
            if (isForceUp)
            {
                _rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * 55f); //Pozisyonumuza göre force veriyor
            }
        }

    }
}

