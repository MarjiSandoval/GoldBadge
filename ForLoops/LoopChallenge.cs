using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ForLoops
{
    [TestClass]
    public class LoopChallenge
    {
        [TestMethod]
        public void loopChallenge()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);

            }
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine("i");
                }
                else if (letter == 'l')
                {
                    Console.WriteLine("l");
                }
                else
                {
                    Console.WriteLine($"Not an i or l : {letter}");
                }

                Console.WriteLine("Using a while loop.");
                //Initalize a counter
                int count = 1;
                while (count < word.Length)
                {
                    //this counts up once per character
                    count++;
                }
                Console.WriteLine("Totale count" + count);

                Console.WriteLine($"Actual count: {word.Length}");


            }
        }

    }
}

