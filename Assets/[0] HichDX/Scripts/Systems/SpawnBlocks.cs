using UnityEngine;

namespace HichDX
{
    public class SpawnBlocks : MonoBehaviour
    {
        [SerializeField] private Configuration _configuration;
        [SerializeField] private SetupBlocks _setupBlocks;
        [SerializeField] private TimeSO _timeSO;

        [SerializeField] private Transform _posSpawn;
        


        private void Start()
        {
            InvokeRepeating("Spawn", _timeSO.timeStart, _timeSO.repearRate);

            TakePointComponent.Instance.pointAction += StopSpawn;
        }

        private void Spawn()
        {
            var blocksPrefab = _setupBlocks.setup[Random.Range(0, _setupBlocks.setup.Count)];

            Instantiate(blocksPrefab, _posSpawn.position, _posSpawn.rotation);
        }

        private void StopSpawn(int points)
        {
            var valueForBossBattle = _configuration.valueForBossBattle;

            if (points == valueForBossBattle)
            {
                CancelInvoke("Spawn");
            }
        }
    }
}
