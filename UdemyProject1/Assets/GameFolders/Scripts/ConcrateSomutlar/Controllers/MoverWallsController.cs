using UdemyPorject1.Abstracts.Controllers;
using UnityEngine;

namespace UdemyPorject1.Controllers
{
    public class MoverWallsController : WallController
    {
        [SerializeField] Vector3 _direction;
        [Range(0f, 1f)][SerializeField] float _factor;
        Vector3 _startPosition;

        void Awake()
        {
            _startPosition = transform.position;
        }

        void Update()
        {
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }

}