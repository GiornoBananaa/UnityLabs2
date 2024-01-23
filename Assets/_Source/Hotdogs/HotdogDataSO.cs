using UnityEngine;

namespace Hotdogs
{
    [CreateAssetMenu(fileName = "HotdogDataSO", menuName = "SO/HotdogDataSO", order = 1)]
    public class HotdogDataSO : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Weight { get; private set; }
    }
}
