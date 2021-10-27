using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopChallenge
    {
        private string super;

        [TestInitialize]
        public void Init()
        {
            super = "Supercalifragilisticexpialidocious";
        }

        [TestMethod]
        public void W1D3_ConditionsAndLoopsChallenge_1()
        {
            foreach (char letter in super)
            {
                Console.WriteLine(letter);
            }
        }
        [TestMethod]
        public void W1D3_ConditionsAndLoopsChallenge_2_WithLetter_L_Check()
        {
            foreach (char letter in super)
            {
                //'i' is case sensitive -> can not use 'I'
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                //'l' is case sensitive -> can not use 'L'
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine($"Not an i or l : {letter}");
                }
            }
        }
        [TestMethod]
        public void W1D3_ConditionsAndLoopsChallenge_2_WithLetter_L_Check_Or()
        {
            foreach (char letter in super)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine($"Not an i or l: {letter}");
                }
            }
        }
        [TestMethod]
        public void W1D3_ConditionsAndLoopsChallenge_2_WithLetter_L_Check_Switch()
        {
            foreach (char letter in super)
            {
                switch (letter)
                {
                    case 'i':
                        Console.WriteLine(letter);
                        break;
                    case 'l':
                        Console.WriteLine(letter);
                        break;
                    default:
                        Console.WriteLine($"Not an i or l: {letter}");
                        break;
                }
            }
        }
        [TestMethod]
        public void W1D3_ConditionsAndLoopsChallenge_2_Bonus()
        {
            Console.WriteLine("Using a while loop.");
            //initalize a counter
            int count = 1;
            while (count < super.Length)
            {
                //this counts up one per character....
                count++;
            }
            Console.WriteLine("Total count " + count);

            //use a for loop
            for (int i = 0; i < super.Length; i++)
            {
                Console.WriteLine($"This is the letter#: {super[i]}({i})");
            }


            Console.WriteLine($"Actual Count: {super.Length}");
        }
    }
}
