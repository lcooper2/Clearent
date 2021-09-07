namespace ClearentTest.Models.CreditCards
{
    public class MasterCard : CreditCard
    {
        protected override string CardName => "Master Card";
        protected override decimal InterestRate => 5;

        public MasterCard(decimal balance = 0) : base(balance) { }
    }
}