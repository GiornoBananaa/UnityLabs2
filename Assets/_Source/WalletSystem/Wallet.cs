using System;
using System.Collections.Generic;
using CryptoSystem;

namespace WalletSystem
{
    public class Wallet
    {
        private readonly Dictionary<int, int> _cryptoCurrencies;

        public Action<int> OnBalanceChange;
        public Action<int,int> OnCryptoBalanceChange;
        
        public int Balance { get; private set; }
        
        public Wallet(IEnumerable<CryptDataSO> cryptData, int balance)
        {
            Balance = balance;
            _cryptoCurrencies = new Dictionary<int, int>();
            foreach (var crypt in cryptData)
            {
                _cryptoCurrencies.Add(crypt.ID,0);
            }
        }
        
        public void AddCrypt(int cryptoId, int count)
        {
            _cryptoCurrencies[cryptoId] += count;
            OnCryptoBalanceChange?.Invoke(cryptoId,_cryptoCurrencies[cryptoId]);
        }
        
        public bool SpendCrypt(int ID,int count)
        {
            if (_cryptoCurrencies[ID] < count)
                return false;

            _cryptoCurrencies[ID] -= count;
            OnCryptoBalanceChange?.Invoke(ID,_cryptoCurrencies[ID]);
            
            return true;
        }
        
        public bool SpendMoney(int money)
        {
            if (Balance < money)
                return false;

            Balance -= money;
            OnBalanceChange?.Invoke(Balance);
            
            return true;
        }
        
        public void EarnMoney(int money)
        {
            Balance += money;
            OnBalanceChange?.Invoke(Balance);
        }
    }
}
