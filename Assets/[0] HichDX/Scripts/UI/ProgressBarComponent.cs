using UnityEngine;
using UnityEngine.UI;

namespace HichDX
{
    public class ProgressBarComponent : MonoBehaviour
    {
        [SerializeField] private Configuration _configuration;
            
        [SerializeField] private Slider _progressBar;

        private void Start()
        {
            _progressBar.maxValue = _configuration.valueForBossBattle;

            TakePointComponent.Instance.pointAction += OnPlayerProggressBarChanged;
        }

        private void OnPlayerProggressBarChanged(int points)
        {
            _progressBar.value = points;
        }
    }
}
