using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _05_Methods
{
    [TestClass]
    public class MethodTesting
    {
        // 1 access modifier (4) -> public, private, internal, protected
        // 2 return type
        // 3 method signature -> method name and its parameter/args
        // 4 body of the method


        //1     //2    //3
        public void SayHello(string name)
        {
            //4 body of the method....
            Console.WriteLine($"Hello {name}");
        }

        //metod overload...
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }


        [TestMethod]
        public void CreateRandomGreeting()
        {

            //Make a new instance of random class
            Random rnd = new Random();

            //populate an array of strings that represent different greetings
            string[] availableGreetings = new string []
            {
                "Hello",
                "Howdy",
                "Hola",
                "Yo",
                "Greetings"
            };

            //Put the new instance of random to use...
            int randomNumber = rnd.Next(0, availableGreetings.Length);
            
            //grab the random greeting based on the retrived random number
            //ElementAt -> availableGreetings[randomNumber]
            string chosenGreeting = availableGreetings.ElementAt(randomNumber);

            //Write out the greeting
            Console.WriteLine($"{chosenGreeting}!");
        }
    }
}
