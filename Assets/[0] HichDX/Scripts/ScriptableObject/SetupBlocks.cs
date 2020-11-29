using System.Collections.Generic;
using UnityEngine;

namespace HichDX
{
    [CreateAssetMenu(fileName = "SetupBlocks")]
    public class SetupBlocks : ScriptableObject
    {
        public List<GameObject> setup;
    }

}