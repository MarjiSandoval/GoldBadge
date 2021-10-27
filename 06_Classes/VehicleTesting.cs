using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Classes
{
    [TestClass]
    public class VehicleTesting
    {
        
        [TestMethod]
        public void VehicleCheck()
        {
            //Allocating space in memory 
            // to point to the address called
            //"Vehicle"
            //Creating an instance..
            Vehicle vehicle = new Vehicle();

            Console.WriteLine(vehicle.IsRunning);

            //lets turn on the vehicle
            vehicle.TurnOn();
            
            Console.WriteLine(vehicle.IsRunning);

            vehicle.TurnOff();

            Console.WriteLine(vehicle.IsRunning);

            
        }

        [TestMethod]
        public void Properties()
        {
            //new instance of vehicle...
            Vehicle vehicleA = new Vehicle();

            vehicleA.Make = "Honda";

            Console.WriteLine(vehicleA.Make);

            vehicleA.Model = "Civic";
            vehicleA.Milage = 10000d;
            vehicleA.TypeOfVehicle = VehicleType.Car;

            string carDetails = $"{vehicleA.Make} {vehicleA.Model}";

            Console.WriteLine(carDetails);

        }

        [TestMethod]
        public void Methods()
        {
            //create an instance of the Vehicle type
            Vehicle vehicleB = new Vehicle();

            //create an instance of Indicator type
            Indicator indicatorLeft = new Indicator();

            //create an instance of Indicator type
            Indicator indicatorRight = new Indicator();
            
            //assign instances to the vehicleB
            vehicleB.LeftIndicator = indicatorLeft;
            vehicleB.RightIndicator = indicatorRight;

            //calling method to Turn on the vehicle
            vehicleB.TurnOn();

            //turn off the vehicle
            vehicleB.TurnOff();

            vehicleB.LeftIndicator.TurnOn();
            vehicleB.LeftIndicator.TurnOff();

            vehicleB.RightIndicator.TurnOn();
            vehicleB.RightIndicator.TurnOff();
        }
        [TestMethod]
        public void Constructors()
        {
            Vehicle noParameterConstructor = new Vehicle();

            Vehicle car = new Vehicle("Toyota", "Corolla", 21300d);
            Console.WriteLine($"{car.Make} {car.Model} {car.Milage}");
            //car.TypeOfVehicle = VehicleType.Car;

            Vehicle car2 = new Vehicle("Ford", "Mustang", 0d, VehicleType.Car);
            Console.WriteLine(car2.TypeOfVehicle);

            Console.WriteLine(car2.ToString());

        }
    }
}
