using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HichDX
{
    [RequireComponent(typeof(MovableComponent))]
    public class DirectionComponent : MonoBehaviour
    {
        private MovableComponent _movable;

        void Start()
        {
            _movable = GetComponent<MovableComponent>();
        }

        void Update()
        {
            _movable.Move(Vector2.down);
        }
    }

}