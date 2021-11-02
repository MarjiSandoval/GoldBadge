using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges
{
    [TestClass]
    public class CalculatorChallenge
    {
        private Calculator _calc;
        [TestInitialize]
        public void Init()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldGetIntBack()
        {
            //Act
            int actual = _calc.Add(4, 5);
            int expected = 9;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ShouldGetDecimalBack()
        {
            //Act
            decimal actual = _calc.Add(4.5m, 5.5m);
            decimal expected = 10m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_PassInWhateverIWant_Decimal()
        {
            //Act
            decimal actual = _calc.Add(1.1m, 1.2m, 1.3m);
            decimal expected = 3.6m;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FractionFormat_StringValue()
        {
            //Act
            string actual = _calc.Add_FractionFormat(1.1m, 1.2m);
            string expected = "1.1/1.2";

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
