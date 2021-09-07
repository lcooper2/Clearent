using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearentTest.Models
{
    // The wallet class serves as a container for credit cards and to provide information about the credit cards.
    public class Wallet
    {
        private List<CreditCard> CreditCards;

        public Wallet(List<CreditCard> creditCards = null)
        {
            CreditCards = (creditCards == null) ? new List<CreditCard>() : creditCards;
        }

        public decimal GetTotalInterest()
        {
            return CreditCards.Select(card => card.CalculateInterest()).Sum();
        }

        public void AddCard(CreditCard card)
        {
            CreditCards.Add(card);
        }

        public void PrintCards()
        {
            CreditCards.ForEach(card => Console.WriteLine($"{card.GetCardName()} ({card.GetInterestRate()}%)"));
        }
    }
}