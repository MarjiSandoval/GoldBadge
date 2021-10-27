using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van , Motorcycle, Spaceship, Plane, Boat}

    //Abstraction
    public class Vehicle
    {
        //1 Access Modifier 
        //2 type -> type that the property can hold
        //3 name -> name of the property
        //4 getters -> read data /setters ->write 

        //1     //2   //3     //4  
        public string Make { get; set; }
        public string Model { get; set; }
        public double Milage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; set; } = false;

        public Indicator LeftIndicator { get; set; }
        //we need a Right Indicator....

        //Methods-> Actions...
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle.");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle.");
        }

    }

    public class Indicator 
    {
        //we want a bool isFlashing

        //methods: TurnOn() and TurnOff()
    }
}
