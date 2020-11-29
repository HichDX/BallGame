using UnityEngine;

namespace HichDX
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Configuration _configuration;
        
        private SceneData _sceneData;


        private void Start()
        {
            Time.timeScale = 1;
            
            TakeDamageComponent.Instance.damageAction += OnPlayerHealthChanged;
            TakePointComponent.Instance.pointAction += OnPlayerPointsChanged;
            
            _sceneData = GetComponent<SceneData>();
        }

        private void OnPlayerHealthChanged(int health)
        {
            if (health <= 0)
            {
                Time.timeScale = 0;
                _sceneData.UI.SetActive(false);
                _sceneData.ScreenLose.SetActive(true);
            }
        }

        private void OnPlayerPointsChanged(int points)
        {
            var valueForEndGame = _configuration.valueForEndGame;

            if (points == valueForEndGame)
            {
                Time.timeScale = 0;
                _sceneData.UI.SetActive(false);
                _sceneData.ScreenWin.SetActive(true);
            }
        }
    }

}