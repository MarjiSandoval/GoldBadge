using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // Addition
            int sum = a + b;
            // Subtraction
            int difference = 22 - b;
            // Multiplication
            int product = a * b;
            // Division
            int quotient = a / b;
            // Whole numbers drop the reminder/decimal

            // Remainder
            int remainder = a % b;
            // Modulus = %

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(1987, 2, 3);
            TimeSpan timeSpan = today - someDay;
            // Give the time span between those two days.
        }
    }
}
