using System;
using System.Collections.Generic;
using MessageSystem;
using UnityEngine;
using WalletSystem;

namespace CryptoSystem.CryptoShop
{
    public class CryptoShop
    {
        private const string FAILED_BUY_MESSAGE = "Невозможно совершить покупку, недостаточно средств";
        private const string FAILED_SELL_MESSAGE = "Невозможно совершить продажу, недостаточно средств";
        
        private readonly Dictionary<int, int> _cryptCosts;

        private Messeger _messeger;
        private Wallet _wallet;
        public Action<int,int> OnCostChange;
        
        public CryptoShop(IEnumerable<CryptDataSO> cryptData, Wallet wallet, Messeger messeger)
        {
            _cryptCosts = new Dictionary<int, int>();
            _wallet = wallet;
            _messeger = messeger;
            foreach (var crypt in cryptData)
            {
                _cryptCosts[crypt.ID] = (int)Mathf.Lerp(crypt.MinimumCost,crypt.MaximumCost,0.5f);
            }
        }

        public void SetCost(int cryptID, int newCost)
        {
            _cryptCosts[cryptID] = newCost;
            OnCostChange?.Invoke(cryptID,newCost);
        }
        
        public int GetCost(int cryptID)
        {
            return _cryptCosts[cryptID];
        }

        public void Buy(int id)
        {
            if(!_cryptCosts.TryGetValue(id,out int cost)) 
                return;

            if (_wallet.SpendMoney(cost))
            {
                _wallet.AddCrypt(id,1);
            }
            else
            {
                _messeger.WriteMessage(FAILED_BUY_MESSAGE);
            }
        }
        
        public void Sell(int id)
        {
            if (_wallet.SpendCrypt(id,1))
            {
                _wallet.EarnMoney(_cryptCosts[id]);
            }
            else
            {
                _messeger.WriteMessage(FAILED_SELL_MESSAGE);
            }
        }
    }
}
