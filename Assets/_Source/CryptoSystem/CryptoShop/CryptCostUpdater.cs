using Core;
using UnityEngine;

namespace CryptoSystem.CryptoShop
{
    public class CryptCostUpdater : IUpdater
    {
        private CryptDataSO _cryptData;
        private CryptoShop _cryptoShop;
        
        public CryptCostUpdater(ServiceUpdater serviceUpdater,CryptDataSO cryptData, CryptoShop cryptoShop)
        {
            serviceUpdater.AddUpdater(this,cryptData.UpdateFrequency);
            _cryptData = cryptData;
            _cryptoShop = cryptoShop;
        }

        public void Update()
        {
            int a = Random.Range(_cryptData.MinimumCost,_cryptData.MaximumCost);
            int currentCost = _cryptoShop.GetCost(_cryptData.ID);
            int dif = a - currentCost;
            int newCost = (int)(dif * _cryptData.Coefficient) + currentCost;
            _cryptoShop.SetCost(_cryptData.ID,newCost);
        }
    }
}
