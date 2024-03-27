using UnityEngine;

namespace CryptoSystem
{
    [CreateAssetMenu(fileName = "CryptDataSO",menuName = "Crypto/CryptData")]
    public class CryptDataSO : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int MinimumCost { get; private set; }
        [field: SerializeField] public int MaximumCost { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: Range(0,1)]
        [field: SerializeField] public float Coefficient { get; private set; }
        [field: SerializeField] public float UpdateFrequency { get; private set; }
        public int ID => GetInstanceID();
    }
}
