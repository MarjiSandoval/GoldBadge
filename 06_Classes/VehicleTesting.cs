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
    }
}
