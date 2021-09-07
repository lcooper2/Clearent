using System;

namespace ClearentTest.Models
{
    public abstract class CreditCard
    {
        protected abstract string CardName { get; }
        protected abstract decimal InterestRate { get; }
        private decimal Balance;

        public CreditCard(decimal balance = 0)
        {
            Balance = balance;
        }

        public decimal CalculateInterest()
        {
            return Math.Round(((InterestRate/100) * Balance), 2);
        }

        public decimal GetInterestRate()
        {
            return InterestRate;
        }

        public void MakePayment(decimal paymentAmount)
        {
            Balance -= paymentAmount;
        }

        public void ChargeAccount(decimal purchasePrice)
        {
            Balance += purchasePrice;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public string GetCardName()
        {
            return CardName;
        }
    }
}