using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static _06_Classes.Vehicle;

namespace _06_Classes
{
    [TestClass]
    public class VehicleTesting
    {
        [TestMethod]
        public void VehicleCheck()
        {
            //Allocating space in memory
            //to point to the address called Vehicle
            //creating an instance...

            Vehicle vehicle = new Vehicle();

            Console.WriteLine(vehicle.isRunning);

            //lets turn on the vehicle
            vehicle.TurnOn();

            Console.WriteLine(vehicle.isRunning);

            vehicle.TurnOff();

            Console.WriteLine(vehicle.isRunning);

        }

        [TestMethod]
        public void Properties()
        {
            //new instance of vehicle
            Vehicle vehicleA = new Vehicle();

            vehicleA.Make = "Honda";

            Console.WriteLine(vehicleA.Make);

            vehicleA.Model = "Civic";

            vehicleA.Milage = 10000d;

            vehicleA.TypeOfVehicle = VehicleType.car;

            string carDetails = $"{vehicleA.Make} {vehicleA.Model}";
            Console.WriteLine(carDetails);

        }

        [TestMethod]
        public void Methods()
        {
            Vehicle vehicleB = new Vehicle();

            //create an instance of indicator
            Indicator indicatorLeft = new Indicator();
            Indicator indicatorRight = new Indicator();

            vehicleB.LeftIndicator = indicatorLeft;
            vehicleB.RightIndicator = indicatorRight;

            vehicleB.TurnOn();

            vehicleB.TurnOff();

            vehicleB.LeftIndicator.TurnOn();
            vehicleB.LeftIndicator.TurnOff();
            vehicleB.RightIndicator.TurnOff();
            vehicleB.RightIndicator.TurnOn();

        }

        [TestMethod]
        public void Constructors()
        {
            Vehicle car = new Vehicle("Toyota", "Corolla", 21300d);
            Console.WriteLine($"{car.Make} {car.Model} {car.Milage}");

            Vehicle car2 = new Vehicle("Ford", "Mustang", 0d, VehicleType.car);
            Console.WriteLine(car2.TypeOfVehicle);
            Console.WriteLine(car2.ToString());
        }
    }
}

