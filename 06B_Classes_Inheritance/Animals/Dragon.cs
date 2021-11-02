using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06B_Classes_Inheritance.Animals
{
    public class Dragon : Animal
    {
        public Dragon()
        {
            HasFur = false;
            IsMammal = false;
            DietType = DietType.Carnivore;
        }
        public Dragon(bool isKiller)
        {
            IsKiller = isKiller;
        }
        public Dragon(bool isKiller, bool isMammal, bool hasFur, DietType dietType) : base(isMammal,hasFur,dietType)
        {
            IsKiller = isKiller;
        }

        public bool IsKiller { get; set; }

        public void Eat(Animal animal)
        {
            //check to see if animal exists.....
            if (animal !=null)
            {
                switch (DietType)
                {
                    case DietType.Herbivore:
                        Console.WriteLine($"Yuck, You know I can't eat {animal.GetType().Name}!");
                        break;
                    case DietType.Omnivore:
                    case DietType.Carnivore:
                        Console.WriteLine($"Yum I just ate {animal.GetType().Name}!");
                        break;
                    default:
                        Console.WriteLine("Um......");
                        break;
                }
            }
        }
        public class Wyrm : Dragon 
        {
            public Wyrm()
            {
                NumberOfLegs = 0;
            }
        }
        public class Hydra : Dragon
        {
            public int HeadCount { get; set; }
            public void Swim()
            {
                Console.WriteLine("I am swimming!");
            }
        }
        public class IceHydra : Hydra
        {
            public void IceBlaster()
            {
                Console.WriteLine($"{GetType().Name} is using the IceBlaster!");
            }
        }
        public class FireHydra : Hydra
        {
            public void BombsAway()
            {
                Console.WriteLine("This move destroys EveryThing!!!");
            }
            public void CoddleToSleep()
            {
                Console.WriteLine("Rock-A-Bye-Baby!");
            }
        }
        public class MicroHydra : IceHydra 
        {
            //we want this objec to have FireHydra and Hydra stuff
            //but they are two different instances of one another

        }
    }
}
