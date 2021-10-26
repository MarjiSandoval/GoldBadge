using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternaries
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 31;

            // variable = (Condition/Boolean) ? trueResult : falseResult;
            bool isAdult = (age > 17) ? true : false;

            int numOne = 10;

            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            // As an if else
            if (numOne == 10)
                numTwo = 30;
            else
                numTwo = 20;


        }
    }
}
