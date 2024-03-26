using UnityEngine;

namespace CryptoSystem
{
    [CreateAssetMenu(fileName = "CryptDataSO",menuName = "Crypto/CryptData")]
    public class CryptDataSO : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string MinimumCost { get; private set; }
        [field: SerializeField] public string MaximumCost { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: Range(0,1)]
        [field: SerializeField] public float Coefficient { get; private set; }
        [field: SerializeField] public float UpdateFrequency { get; private set; }
    }
    [CreateAssetMenu(fileName = "CryptoExchangeDataSO",menuName = "Crypto/CryptoExchangeData")]
    public class CryptoExchangeDataSO : ScriptableObject
    {
        [field: SerializeField] public CryptDataSO[] Crypts { get; private set; }
        [field: SerializeField] public float StartBalance { get; private set; }
    }
}
