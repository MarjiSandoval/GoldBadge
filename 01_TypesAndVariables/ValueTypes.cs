using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // A declared variable, not initialized
            bool declared;

            // Calling a variable, and assigning value
            declared = true;

            // A variable that was declared and initialized at the same time.
            bool declaredAndInitialized = false;

            // Calling on a variable and assigning it a value
            declaredAndInitialized = true;
        }

        // "testm"
        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

            int a = 10;
            int b = -5;

            int c = a - b;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.04818281f;
            double doubleExample = 1.729582572302302309d;
            decimal decimalExample = -23.28164616411272198122198m;
        }
        enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant };

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Cake;
            PastryType youPastry = PastryType.Cupcake;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthDay = new DateTime(1991, 5, 4);
        }
    }
}
