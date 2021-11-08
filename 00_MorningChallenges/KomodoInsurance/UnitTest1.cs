using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _00_MorningChallenges.KomodoInsurance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VanTesting_ShouldGetAVan()
        {
            Van van = new Van("Honda", "Odessy", "White");
            Van van2 = new Van("Ford", "Econo", "Green");
            var Interfaces = van.GetType().GetInterfaces().ToList();
            van.Drive();
            van2.Drive();
            Assert.IsInstanceOfType(van, typeof(Vehicle));
            Assert.IsTrue(Interfaces.Contains(typeof(IVehicle)));
        }

        [TestMethod]
        public void SedanTesting_ShouldGetSedan()
        {
            Sedan sedan = new Sedan("Ford", "Focus", "Blue");
            Sedan sedan2 = new Sedan("Honda", "Civic", "Black");
            var Interfaces = sedan.GetType().GetInterfaces().ToList();
            sedan.Drive();
            sedan2.Drive();

            Assert.IsInstanceOfType(sedan, typeof(Vehicle));
            Assert.IsTrue(Interfaces.Contains(typeof(IVehicle)));

        }

        [TestMethod]
        public void MotorcycleTesting_ShouldGetMotorcyle()
        {
            Motorcycle motorcycle = new Motorcycle("Harley Davidson", "CVO Limited", "Purple");
            var Interfaces = motorcycle.GetType().GetInterfaces().ToList();
            motorcycle.Drive();

            Assert.IsInstanceOfType(motorcycle, typeof(Vehicle));
            Assert.IsTrue(Interfaces.Contains(typeof(IVehicle)));

        }

        [TestMethod]
        public void SportsCarTesting_ShouldGetSportsCar()
        {
            SportsCar sportsCar = new SportsCar("Dodge", "Challenger", "Blue");
        var Interfaces = sportsCar.GetType().GetInterfaces().ToList();
            sportsCar.Drive();

            Assert.IsTrue(Interfaces.Contains(typeof(IVehicle)));
            Assert.IsInstanceOfType(sportsCar, typeof(Vehicle));
        }
    }
}
