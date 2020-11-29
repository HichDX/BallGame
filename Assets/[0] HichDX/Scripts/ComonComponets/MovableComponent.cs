using UnityEngine;

namespace HichDX
{
    public class MovableComponent : MonoBehaviour
    {
        [SerializeField, Range(0f, 10f)] private float _speed = 5f;

        public void Move(Vector2 direction)
        {
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }
}
