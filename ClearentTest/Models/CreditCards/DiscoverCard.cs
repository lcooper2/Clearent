namespace ClearentTest.Models.CreditCards
{
    public class DiscoverCard : CreditCard
    {
        protected override string CardName => "Discover Card";
        protected override decimal InterestRate => 1;

        public DiscoverCard(decimal balance = 0) : base(balance) { }
    }
}