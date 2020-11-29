using System.Collections;
using UnityEngine;

namespace HichDX
{
    public class TakeDamageComponent : Singleton<TakeDamageComponent>
    {
        private Animator _playerAnim;
        private CircleCollider2D _playerCol;

        private int _health = 3;

        public delegate void OnDamageAction(int health);

        public event OnDamageAction damageAction;

        private void Awake()
        {
            _playerAnim = GetComponent<Animator>();
            _playerCol = GetComponent<CircleCollider2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Blocks"))
            {
                Destroy(collision.gameObject);
                StartCoroutine(Damage());
                _health--;
                damageAction.Invoke(_health);

                if (_health <= 0)
                {
                    Destroy(gameObject);
                    _health = 0;
                }
            }
        }

        private IEnumerator Damage()
        {
            _playerAnim.SetBool("isDamage", true);
            _playerCol.enabled = false;

            yield return new WaitForSeconds(1.5f);

            _playerAnim.SetBool("isDamage", false);
            _playerCol.enabled = true;
        }
    }
}
