using ClearentTest.Models;
using ClearentTest.Models.CreditCards;
using NUnit.Framework;
using System.Collections.Generic;

namespace ClearentUnitTests
{
    [TestFixture]
    public class Tests
    {
        private Person person1; 
        private Person person2; 
        private Person person3; 
        private Person person4;

        [SetUp]
        public void Setup()
        {
            person1 = new Person();
            List<CreditCard> p1Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100), new DiscoverCard(100) };
            var p1Wallet = new Wallet(p1Cards);
            person1.AddWallet(p1Wallet);

            person2 = new Person();
            List<CreditCard> p2CardsW1 = new List<CreditCard>() { new Visa(100), new DiscoverCard(100) };
            List<CreditCard> p2CardsW2 = new List<CreditCard>() { new MasterCard(100) };
            var p2Wallet1 = new Wallet(p2CardsW1);
            var p2Wallet2 = new Wallet(p2CardsW2);
            person2.AddWallet(p2Wallet1);
            person2.AddWallet(p2Wallet2);

            person3 = new Person();
            List<CreditCard> p3Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100) };
            var p3Wallet = new Wallet(p3Cards);
            person3.AddWallet(p3Wallet);

            person4 = new Person();
            List<CreditCard> p4Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100) };
            var p4Wallet = new Wallet(p4Cards);
            person4.AddWallet(p4Wallet);
        }

        [Test]
        public void Test1()
        {
            // 10% on visa =$10, 5% on mastercard = $5, 1% on discover = $1 for a total of $16
            Assert.IsTrue(person1.GetTotalInterest() == 16);
        }

        [Test]
        public void Test2()
        {
            // 10% on visa =$10, 5% on mastercard = $5, 1% on discover = $1 for a total of $16
            Assert.IsTrue(person2.GetTotalInterest() == 16);
        }

        [Test]
        public void Test3()
        {
            // 10% on visa =$10, 5% on mastercard = $5 for a total of $15 for both people
            Assert.IsTrue(person3.GetTotalInterest() == 15);
            Assert.IsTrue(person4.GetTotalInterest() == 15);
        }
    }
}