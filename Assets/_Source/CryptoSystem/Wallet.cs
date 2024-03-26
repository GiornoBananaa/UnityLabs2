using System;
using System.Collections.Generic;

namespace CryptoSystem
{
    public class Wallet
    {
        private readonly Dictionary<int, int> _cryptoCurrencies;
        private int _balance;
        
        public Action<int> OnBalanceChange;
        
        public Wallet(IEnumerable<CryptDataSO> cryptData, int balance)
        {
            _balance = balance;
            _cryptoCurrencies = new Dictionary<int, int>();
            foreach (var crypt in cryptData)
            {
                _cryptoCurrencies.Add(crypt.GetInstanceID(),0);
            }
        }
        
        public void AddCrypt(int cryptoId, int count)
        {
            _cryptoCurrencies[cryptoId] += count;
        }
        
        public bool SpendMoney(int money)
        {
            if (_balance < money)
                return false;

            _balance -= money;
            OnBalanceChange?.Invoke(_balance);
            
            return true;
        }
    }
}
