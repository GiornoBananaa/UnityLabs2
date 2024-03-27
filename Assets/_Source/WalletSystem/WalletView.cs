using TMPro;
using UnityEngine;

namespace WalletSystem
{
    public class WalletView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _balanceText;

        private Wallet _wallet;
        
        public void Construct(Wallet wallet)
        {
            _wallet = wallet;
            SetBalance(wallet.Balance);
            _wallet.OnBalanceChange += SetBalance;
        }

        private void SetBalance(int balance)
        {
            _balanceText.text = $"{balance}$";
        }

        private void OnDestroy()
        {
            _wallet.OnBalanceChange -= SetBalance;
        }
    }
}
