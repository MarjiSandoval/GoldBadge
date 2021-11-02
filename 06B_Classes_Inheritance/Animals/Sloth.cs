using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06B_Classes_Inheritance.Animals
{
    public class Sloth : Animal
    {
        public Sloth()
        {
            Console.WriteLine("Sloth Constructor");
        }
        //Want to make a property, but 'Read-only'
        public bool IsSlow 
        {
            get { return true; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Yawn. :)");
        }
        public override void Move()
        {
            Console.WriteLine("The Sloth moves slowly.");
        }
    }

    public class Megatherium : Sloth 
    {
        public Megatherium()
        {
            Console.WriteLine("This sloth is extinct.");
        }
        public override void Move()
        {
            Console.WriteLine("Megatherium uses Move! It's not super effective...");
        }
    }
}
