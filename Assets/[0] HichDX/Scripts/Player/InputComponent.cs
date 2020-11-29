using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HichDX
{
    [RequireComponent(typeof(MovableComponent))]
    public class InputComponent : MonoBehaviour
    {
        [SerializeField] private Joystick _joystik;

        private MovableComponent _movable;

        
        private void Start()
        {
            _movable = GetComponent<MovableComponent>();
        }

        void Update()
        {
            var direction = new Vector2(_joystik.Horizontal, 0);

            _movable.Move(direction);
        }
    }
}
