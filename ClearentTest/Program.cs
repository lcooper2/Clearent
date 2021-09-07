using ClearentTest.Models;
using ClearentTest.Models.CreditCards;
using System;
using System.Collections.Generic;

namespace ClearentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            Person person2;
            Person person3;
            Person person4;

            List<CreditCard> p1Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100), new DiscoverCard(100) };
            var p1Wallet = new Wallet(p1Cards);
            person1 = new Person();
            person1.AddWallet(p1Wallet);

            List<CreditCard> p2Cards1 = new List<CreditCard>() { new Visa(100), new DiscoverCard(100) };
            List<CreditCard> p2Cards2 = new List<CreditCard>() { new MasterCard(100) };
            var p2Wallet1 = new Wallet(p2Cards1);
            var p2Wallet2 = new Wallet(p2Cards2);
            person2 = new Person();
            person2.AddWallet(p2Wallet1);
            person2.AddWallet(p2Wallet2);

            List<CreditCard> p3Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100) };
            var p3Wallet = new Wallet(p3Cards);
            person3 = new Person();
            person3.AddWallet(p3Wallet);

            List<CreditCard> p4Cards = new List<CreditCard>() { new Visa(100), new MasterCard(100) };
            var p4Wallet = new Wallet(p4Cards);
            person4 = new Person();
            person4.AddWallet(p4Wallet);

            Console.WriteLine(person1.GetTotalInterest());
            Console.WriteLine(person2.GetTotalInterest());
            Console.WriteLine(person3.GetTotalInterest());
            Console.WriteLine(person4.GetTotalInterest());
        }
    }
}
