using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06B_Classes_Inheritance.Animals
{
    public enum DietType { Herbivore=1,Omnivore,Carnivore}
    public abstract class Animal
    {
        public Animal()
        {
        }
        public Animal(bool isMammal, bool hasFur, DietType dietType)
        {
            IsMammal = isMammal;
            HasFur = hasFur;
            DietType = dietType;
        }
        //Assign some properties
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public  DietType DietType{get;set;}

        public virtual void MakeSound()
        {
            Console.WriteLine("I am making a sound.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
        protected void DoSomething()
        {
            Console.WriteLine("???");
        }

        //this is only seen w/n the assembly '06B_Classes_Inheritance'
        //internal void DoSomething()
        //{
        //    Console.WriteLine("???");
        //}
    }
}
