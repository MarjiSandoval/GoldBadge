using _09_Interfaces_WorkingWith_DI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_Interfaces_WorkingWith_DI
{
    [TestClass]
    public class TransactionTests
    {

        //make some debt
        private decimal _debt;

        //method that will help us payoff debt
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }
        [TestInitialize]
        public void Init()
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            //Setup Init ->
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.52m));

            var expected = 9000.01m - 316.52m;

            Assert.AreEqual(expected, _debt);
            Console.WriteLine(_debt);
        }
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            //we have our Icurrencies...
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(247.71m);

            //creating variable to hod the transaction data;
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(247.71m, secondTransaction.GetTransactionAmount());

        }
        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>()
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Dime()),
                new Transaction(new Dollar()),
                new Transaction(new Penny())
            };
            //foreach trough the list, and...
            foreach (var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetTransactionType();

                
                Console.WriteLine($"{type} ${amount} {transaction.DateOfTransaction}");

            }


        }
    }
}
