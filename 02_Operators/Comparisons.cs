using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparison()
        {
            int age = 25;
            string username = "Peter";

            // Equals ==
            bool equals = age == 31;
            bool userIsEddie = username == "Eddie";
            Console.WriteLine("User is 31: " + equals);
            Console.WriteLine($"User is Eddie: {userIsEddie}");

            // Inequals != ! is called bang operator
            bool notEqual = age != 112;
            bool isNotJustin = username != "Justin";
            Console.WriteLine("User is not 112: {0}",notEqual);
            Console.WriteLine($"User is not Justin: {isNotJustin}");

            // Equality in reference types
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            firstList.Add(username);
            secondList.Add(username);

            // References aren't equal, even if values are
            bool areEqual = firstList == secondList;
            Console.WriteLine(areEqual);
            bool valuesAreEqual = firstList[0] == secondList[0];
            Console.WriteLine(valuesAreEqual);


            // Greater, Lesser than and it's variants
            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;

            bool lessThan = age < 66;
            bool lessThanOrEqual = age <= 30;

            bool trueValue = true;
            bool falseValue = false;

            // Or
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");

            // And
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;
            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and False: {fAndF}");
        }
    }
}
