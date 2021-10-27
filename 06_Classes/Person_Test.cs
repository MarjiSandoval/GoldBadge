using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Classes
{
    [TestClass]
    public class Person_Test
    {
        [TestMethod]
        public void PeopleTester()
        {
            Person firstPerson = new Person("Terry","Brown",new DateTime(2012,07,07));

            Console.WriteLine($"{firstPerson.FullName} is {firstPerson.Age}");
            
            //Person blankPerson = new Person();

            //Console.WriteLine($"{blankPerson.FullName} is {blankPerson.Age}");

            //assign a vehicle to firstPerson
            firstPerson.Transport = new Vehicle("Ford","Mustang Gt 500",2000d,VehicleType.Car);
            
            Console.WriteLine($"{firstPerson.FullName } owns {firstPerson.Transport}");

        }
    }
}
