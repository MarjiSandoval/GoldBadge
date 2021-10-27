using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Methods
{
    [TestClass]
    public class CalcTest
    {

        private Calculator calc;

        [TestInitialize]
        public void Init()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestingAddMethod()
        {
            int a = 4;
            int b = 25;

           int sum = calc.Add(a, b);

            Console.WriteLine(sum);

        }
        [TestMethod]
        public void TestingSubtractMethod()
        {
            int firstNumber = 77;
            int secondNumber = 10;

            int value = calc.Subtract(firstNumber, secondNumber);
            Console.WriteLine(value);
        }
        [TestMethod]
        public void TestingDivision()
        {
            int firstNumber = 77;
            int secondNumber = 10;

            decimal value = calc.Divide(firstNumber, secondNumber);
            Console.WriteLine(value);
        }
        [TestMethod]
        public void TestingDivision_zeroCheck_returns_zero()
        {
            int firstNumber = 77;
            int secondNumber = 0;

            decimal value = calc.Divide(firstNumber, secondNumber);
            Console.WriteLine(value);
        }
        [TestMethod]
        public void FindRemainderTest()
        {
            int firstNumber = 77;
            int secondNumber = 10;

            int val = calc.FindRemainder(firstNumber, secondNumber);

            Console.WriteLine(val);
        }
    }
}
