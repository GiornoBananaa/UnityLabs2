using CryptoSystem;
using CryptoSystem.CryptoShop;
using MessageSystem;
using UnityEngine;
using WalletSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private const string CRYPTO_EXCHANGE_DATA_PATH = "CryptoExchangeDataSO";
        
        [SerializeField] private ScrollingCryptoPurchaseLayout _purchaseLayout;
        [SerializeField] private ScrollingCryptoWalletLayout _walletLayout;
        [SerializeField] private WalletView _walletView;
        [SerializeField] private ServiceUpdater _serviceUpdater;
        [SerializeField] private Messeger _messeger;
        
        private Wallet _wallet;
        private CryptoExchangeDataSO _cryptoExchangeData;
        private CryptoShop _cryptoShop;
        
        private void Awake()
        {
            _cryptoExchangeData = Resources.Load<CryptoExchangeDataSO>(CRYPTO_EXCHANGE_DATA_PATH);
            _wallet = new Wallet(_cryptoExchangeData.Crypts,_cryptoExchangeData.StartBalance);
            _walletView.Construct(_wallet);
            _cryptoShop = new CryptoShop(_cryptoExchangeData.Crypts, _wallet,_messeger);
            foreach (var cryptData in _cryptoExchangeData.Crypts)
            {
                CryptCostUpdater costUpdater = new CryptCostUpdater(_serviceUpdater, cryptData, _cryptoShop);
                
                _serviceUpdater.AddUpdater(costUpdater, cryptData.UpdateFrequency);
                
                CryptoPurchaseElement newPurchaseElement = _purchaseLayout.InstantiateNewElement();
                newPurchaseElement.Construct(cryptData, _cryptoShop);
                
                WalletCryptCountElement newWalletElement = _walletLayout.InstantiateNewElement();
                newWalletElement.Construct(cryptData,_wallet, _cryptoShop);
            }
        }
    }
}
