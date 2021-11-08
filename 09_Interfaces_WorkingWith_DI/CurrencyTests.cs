using _09_Interfaces_WorkingWith_DI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _09_Interfaces_WorkingWith_DI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();

            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        [TestMethod]
        public void DimeTests()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual(0.1m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }

        [TestMethod]
        public void DollarTests()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual(1m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(1.50)]
        [DataRow(19)]
        public  void EPaymentTest(double value)
        {
            //convert eac h of these values to decimal
            decimal convertedValue = Convert.ToDecimal(value);

            var ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment",ePayment.Name);
        }
       
    }
}
