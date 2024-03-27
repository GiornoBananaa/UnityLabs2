using UnityEngine;

namespace CryptoSystem
{
    [CreateAssetMenu(fileName = "CryptoExchangeDataSO",menuName = "Crypto/CryptoExchangeData")]
    public class CryptoExchangeDataSO : ScriptableObject
    {
        [field: SerializeField] public CryptDataSO[] Crypts { get; private set; }
        [field: SerializeField] public int StartBalance { get; private set; }
    }
}