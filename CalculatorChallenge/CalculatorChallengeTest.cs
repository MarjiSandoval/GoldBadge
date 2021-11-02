using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorChallenge
{
    [TestClass]
    public class CalculatorChallengeTest
    {
        private Calculator _calc;

        [TestInitialize]
        public void Init()
        {
            _calc = new Calculator();
        }
        [TestMethod]
        public void AddTwoNumbers_ReturnCorrectAnswer()
        {
            int actual = _calc.Add(5, 6);
            int expected = 11;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void SubtractTwoNumbers_RetrunCorrectAnswer()
        {
            int actual = _calc.Subtract(9, 15);
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyTwoNumber_ReturnCorrectAnswer()
        {
            int actual = _calc.multiply(9, 9);
            int expected = 81;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTwoNumbers_ReturnCorrectAnswer()
        {
            int actual = _calc.divide(50, 5);
            int expected = 10;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddTwoDecimals_ReturnCorrectSum()
        {
            decimal actual = _calc.Add(0.75m, 15.92m);
            decimal expected = 16.67m;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractDecimals_ReturnCorrectProduct()
        {
            decimal actual = _calc.Subtract(0.75m, 15.92m);
            decimal expected = 15.17m;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyDecimals_ReturnCorrectAnswer()
        {
            decimal actual = _calc.multiply(0.75m, 15.92m);
            decimal expected = 11.94m;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTwoDecimals_ReturnCorrectQuotient()
        {
            decimal actual = _calc.Add(0.75m, 15.92m);
            decimal expected = 16.67m;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PassInAnything_Decimal()
        {
            //Act
            decimal actual = _calc.Add(1.1m, 1.2m, 1.3m);
            decimal expected = 3.6m;

            Assert.AreEqual(expected, actual);
        }
    }  
}
