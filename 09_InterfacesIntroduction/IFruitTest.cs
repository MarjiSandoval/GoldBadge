using _09_InterfacesIntroduction.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_InterfacesIntroduction
{
    [TestClass]
    public class IFruitTest
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            //declare an interface instance
            IFruit banana = new Banana();

           var output = banana.Peel();

            Console.WriteLine(output);

            //this is th make sure that the bool was switched during the abouve method call (banana.Peel())
            Console.WriteLine($"Is the banana peeled: {banana.IsPeeled}");

            Assert.IsTrue(banana.IsPeeled);
        }
        [TestMethod]
        public void InterfacesInCollections()
        {
            // Make and orange obj
            Orange orange = new Orange();

            //Make a collection but, of IFruit:
            var fruitSalad = new System.Collections.Generic.List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange
            };

            //loop throught the fruitSalad to see contents
            //foreach IFruit 'fruit' inside of the fruitSalad (collection)
            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                //Assert
                Assert.IsInstanceOfType(fruit, typeof(IFruit));

                
            }
        }
        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is named: {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            //use a class that implements IFruit
            Grape grape = new Grape();

            //USING HELPER METHOD
            var output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is named: Grape."));
        }
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            // to loop over this collection and check if the orange is peeled.
            // fruit is the typed that is being looped over at the time
            //is '==' Orange (type)
            //if it is the we store the value w/n the variable orange
            Console.WriteLine("Is the orange peeled?");

            foreach (var fruit in fruitSalad)
            {
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("Is a peeled Orange.");
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("Is an Orange.");
                    }
                }
                //using the type of method
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Is a Grape.");

                    //an example w/o using pattern matching
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("Is a peeled Banana.");

                }
                else
                {
                    Console.WriteLine("Is a Banana");
                }

            }

        }
    }
}
