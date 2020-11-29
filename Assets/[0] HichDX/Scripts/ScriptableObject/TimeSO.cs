using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HichDX
{
    [CreateAssetMenu(fileName ="Time")]
    public class TimeSO : ScriptableObject
    {
        [Range(0f, 10f)] public float timeStart = 2f;
        [Range(0f, 10f)] public float repearRate = 2f;
    }
}
