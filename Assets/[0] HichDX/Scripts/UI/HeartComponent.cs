using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HichDX
{
    public class HeartComponent : MonoBehaviour
    {
        [SerializeField] private List<Image> _hearts;

        private int _index;

        private void Start()
        {
            TakeDamageComponent.Instance.damageAction += OnPlayerHealthChanged;
            _index = _hearts.Count - 1;
        }

        private void OnPlayerHealthChanged(int health)
        {
            if (health >= 0)
            {
                _hearts[_index].enabled = false;
                _index--;
            }

        }
    }
}
