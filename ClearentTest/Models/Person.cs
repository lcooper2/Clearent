using System.Collections.Generic;
using System.Linq;

namespace ClearentTest.Models
{
    public class Person
    {
        private List<Wallet> Wallets;

        public Person(List<Wallet> wallets = null)
        {
            Wallets = (wallets == null) ? new List<Wallet>() : wallets;
        }
        public void AddWallet(Wallet wallet)
        {
            Wallets.Add(wallet);
        }

        public void ShowWallets()
        {
            Wallets.ForEach(wallet => wallet.PrintCards());
        }
        public decimal GetTotalInterest()
        {
            return Wallets.Select(wallet => wallet.GetTotalInterest()).Sum();
        }
    }
}