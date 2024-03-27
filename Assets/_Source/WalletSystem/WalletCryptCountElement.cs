using CryptoSystem;
using CryptoSystem.CryptoShop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ILayoutElement = Core.ILayoutElement;

namespace WalletSystem
{
    public class WalletCryptCountElement : MonoBehaviour, ILayoutElement
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _countText;
        [SerializeField] private Image _icon;
        [SerializeField] private Button _sellButton;

        private int _cryptID;
        private CryptoShop _cryptoShop;
        
        [field:SerializeField] public RectTransform RectTransform { get; private set; }

        public void Construct(CryptDataSO cryptData, Wallet wallet, CryptoShop cryptoShop)
        {
            _nameText.text = cryptData.Name;
            _icon.sprite = cryptData.Icon;
            _countText.text = 0.ToString();
            _cryptID = cryptData.ID;
            _cryptoShop = cryptoShop;
            _sellButton.onClick.AddListener(Sell);
            wallet.OnCryptoBalanceChange += UpdateCount;
        }
        
        private void UpdateCount(int ID,int count)
        {
            if(_cryptID!=ID) return;
            
            _countText.text = count.ToString();
        }

        private void Sell()
        {
            _cryptoShop.Sell(_cryptID);
        }
    }
}
