using UdemyProject1.Inputs;
using UnityEngine;

namespace UdemyPorject1.Controllers
{

    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        private Rigidbody _rigithBody;

        DefaultInput _defaultInput;

        bool _isForceUp;
        private void Awake()
        {
            _rigithBody = GetComponent<Rigidbody>();//Cache yapıyoruz burada
            _defaultInput = new DefaultInput();
          

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
            if (_isForceUp)
            {
                _rigithBody.AddForce(Vector3.up * Time.deltaTime * _force);   
            }
        }
    }

}

