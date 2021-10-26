using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoop()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }
            Console.WriteLine("While loop over");

            total = 0;

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }
                Console.WriteLine(total);
                total++;
            }

            Random randy = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = randy.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }

                Console.WriteLine(someCount);

                if (someCount == 15)
                    keepLooping = false;
            }
        }

        [TestMethod]
        public void ForLoop()
        {
            int studentCount = 15;

            // 1 Starting point
            // 2 While this condition is true
            // 3 What happens after each loops
            // 4 Code we execute

                      //1       //2           //3
            for (int i = 0; i < studentCount; i++)
            {
                // 4
                Console.WriteLine(i);
            }

            string[] students = { "Jason", "Rob", "Jacquelyn", "Jon", "Bec", "Marji" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}!");
            }
        }

        [TestMethod]
        public void ForeachLoop()
        {
            string[] students = { "Jason", "Rob", "Jacquelyn", "Jon", "Bec", "Marji" };
            // 1 Type in the collection
            // 2 Name of the current iteration
            // 3 "in" Keyword to seperate the individual items in the collection
            // 4 Collection being worked on
            //foreach //1     //2  //3    //4
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in class.");
            }

            string name = "Henry Allen Venture";
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine(iterator);
                iterator++;
            }
            while (iterator <= 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);

            // traditional while loop
            while (false)
            {
                Console.WriteLine("My do while condition is false!");
            }
        }
    }
}
