using UnityEngine;

namespace HichDX
{
    public class SpawnBoss : MonoBehaviour
    {
        [SerializeField] private Configuration _configuration;

        [SerializeField] private GameObject _boss;
        [SerializeField] private Camera _camera;
        [SerializeField] private AudioClip _music;

        private void Start()
        {
            TakePointComponent.Instance.pointAction += Spawn;
        }

        private void Spawn(int points)
        {
            var audioSource = _camera.GetComponent<AudioSource>();
            var valueForBossBattle = _configuration.valueForBossBattle;

            if (points == valueForBossBattle)
            {
                _boss.SetActive(true);

                audioSource.clip = _music;
                audioSource.Play();
            } 
        }
    }
}
