using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06B_Classes_Inheritance.Animals
{
    public class Cat : Animal
    {
        //Constructor
        public Cat()
        {
            Console.WriteLine("this is the Cat Constructor");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }
        //Properties
        public double ClawLength { get; set; }
        //Methods
        public override void MakeSound()
        {
            //base.Makesound=> this derives from the base class
            base.MakeSound();
            Console.WriteLine("Meow, meow...");

        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly.");
        }
    }

    public class TabbyCat : Cat
    {
        public TabbyCat()
        {
            Console.WriteLine("This is the TabbyCat Constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Purrrr!");
        }
        public class Liger : Cat
        {
            public Liger()
            {
                Console.WriteLine("this is the Liger Constructor" );
            }
            public override void MakeSound()
            {
                Console.WriteLine("Roar!!");
            }
            public override void Move()
            {
                Console.WriteLine($"The {GetType().Name} stalks its prey");
            }
        }
    }
}
