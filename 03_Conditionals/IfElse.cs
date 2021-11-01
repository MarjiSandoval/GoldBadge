using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!!");
            }

            int age = 15;
            if (age  < 18)
            {
                Console.WriteLine("You are not legally and adult yet"); 
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("You must stay home and finishe you Chores");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            { 
                Console.WriteLine("You should be well rested");
            
            }
            else
            {
                Console.WriteLine("You must be tired today");
                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more sleep!");
                }
            }


        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            int age = 55;

            if (age > 17)
            {
                Console.WriteLine("YOur and adult!");
            }
            else
            {
                if (age > 6)
                    Console.WriteLine("You're a kid!");
                else if (age > 0)
                    Console.WriteLine("You're too young to use a computer!");
                else
                    Console.WriteLine("You're not even born yet");

                
            }

            if (age >= 55)
            {
                Console.WriteLine("Senior Discount Time");
            }
            else if (age > 21 && age < 55)
            {
                Console.WriteLine("Age is between 21 and 55");
            }
            else if (age == 21)
                Console.WriteLine("You can drink now!");
            else if (age <=19)            
                Console.WriteLine("YOu're either a teenage or will be soon");
            else
            {
                Console.WriteLine("You must be 20");
            }

            
               
            
        }
    }
}
