using UdemyPorject1.Abstracts.Controllers;
using UnityEngine;

namespace UdemyPorject1.Controllers
{
    public class MoverWallsController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _factor;
        [SerializeField] float _speed = 1f;
        Vector3 _startPosition;

        const float FULL_CRIClE = Mathf.PI * 2f;

        void Awake()
        {
            _startPosition = transform.position;
        }

        void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CRIClE);
            _factor = sinWave / 2f + 0.5f;
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;

        }
    }

}