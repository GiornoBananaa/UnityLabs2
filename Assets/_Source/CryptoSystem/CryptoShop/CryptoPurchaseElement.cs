using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ILayoutElement = Core.ILayoutElement;

namespace CryptoSystem.CryptoShop
{
    public class CryptoPurchaseElement : MonoBehaviour, Core.ILayoutElement
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _costText;
        [SerializeField] private Image _icon;
        [SerializeField] private Button _buyButton;
        
        private int _cryptoID;
        private CryptoShop _cryptoShop;

        [field:SerializeField] public RectTransform RectTransform { get; private set; }

        public void Construct(CryptDataSO cryptData, CryptoShop cryptoShop)
        {
            _nameText.text = cryptData.Name;
            _icon.sprite = cryptData.Icon;
            _costText.text = $"${cryptData.MinimumCost}";
            _cryptoID = cryptData.ID;
            _cryptoShop = cryptoShop;
            _cryptoShop.OnCostChange += UpdateCost;
        }
        
        private void Start()
        {
            _buyButton.onClick.AddListener(Buy);
        }
        
        private void OnDestroy()
        {
            _cryptoShop.OnCostChange -= UpdateCost;
        }
        
        private void UpdateCost(int ID,int newCost)
        {
            if(ID!=_cryptoID) return;
            
            _costText.text = $"${newCost}";
        }
        
        private void Buy()
        {
            _cryptoShop.Buy(_cryptoID);
        }
    }
}