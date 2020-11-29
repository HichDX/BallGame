using UnityEngine;

namespace HichDX
{
    [CreateAssetMenu(fileName ="Configuration")]
    public class Configuration : ScriptableObject
    {
        public int valueForBossBattle = 5;
        public int valueForEndGame = 5;
    }

}