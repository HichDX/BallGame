using System.Collections;
using UnityEngine;

namespace HichDX
{
    public class BossAI : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPref;
        [SerializeField] private GameObject _point;

        [SerializeField] private Transform _spawnBullet;

        [SerializeField] private TimeSO _time;
        [SerializeField] private BossBattleSO _bossBattle;
        

        private Animator _anim;

        private void Awake()
        {
            _anim = GetComponent<Animator>();
        }

        private void Start()
        {
            TakePointComponent.Instance.pointAction += StopSpawnBullet;
        }

        public void StartAttack()
        {
            InvokeRepeating("SpawnBullet", _time.timeStart, _time.repearRate);
            StartCoroutine(SpawnPoint());
        }

        private void SpawnBullet()
        {
            Instantiate(_bulletPref, _spawnBullet.position, _spawnBullet.rotation);
        }

        private IEnumerator SpawnPoint()
        {
            yield return new WaitForSecondsRealtime(20);

            Instantiate(_point, _point.transform.position, _point.transform.rotation);
        }

        private void StopSpawnBullet(int points)
        {
            var bossBattle = _bossBattle.valueForTransitionEmoteBoss;

            if (points == bossBattle[0])
            {
                CancelInvoke("SpawnBullet");
                StopCoroutine(SpawnPoint());
                _anim.SetTrigger("isTransition");
            }

            if (points == bossBattle[1])
            {
                CancelInvoke("SpawnBullet");
                StopCoroutine(SpawnPoint());
                _anim.SetTrigger("isTransition");
            }

            if (points == bossBattle[2])
            {
                CancelInvoke("SpawnBullet");
                StopCoroutine(SpawnPoint());
                _anim.SetTrigger("isTransition");
            }
        } 

    }
}
