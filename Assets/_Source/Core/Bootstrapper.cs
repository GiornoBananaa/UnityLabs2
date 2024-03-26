using System;
using CryptoSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private const string CRYPTO_EXCHANGE_DATA_PATH = "CryptoExchangeDataSO";
        
        private Wallet _wallet;
        private CryptoExchangeDataSO _cryptoExchangeData;
        
        private void Awake()
        {
            _cryptoExchangeData = Resources.Load<CryptoExchangeDataSO>(CRYPTO_EXCHANGE_DATA_PATH);
            _wallet = new Wallet(_cryptoExchangeData.Crypts,0);
        }
    }
}
