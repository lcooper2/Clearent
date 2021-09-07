namespace ClearentTest.Models.CreditCards
{
    public class Visa : CreditCard
    {
        protected override string CardName => "Visa";
        protected override decimal InterestRate => 10;

        public Visa(decimal balance = 0) : base(balance) { }
    }
}