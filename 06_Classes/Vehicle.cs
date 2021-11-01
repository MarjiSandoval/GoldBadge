using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { car, truck, van, motorcycle, spaceship, plane, boat}


    //Abstraction
    //fields->private backing field
    //Constructors -> used to make objects on the fly
    //Properties -> attributes of and object(class)
    //Methods -> actions that an object can do
    public class Vehicle
    {

        //ctor ->tab ->tab (constructor)
        public Vehicle()
        {
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }

        public Vehicle(string make, string model, double milage)
        {
            Make = make;
            Model = model;
            Milage = milage;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }

        public Vehicle(string make, string model, double milage, VehicleType vehicleType)
        {
            Make = make;
            Model = model;
            Milage = milage;
            TypeOfVehicle = vehicleType;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }
        //1 Access Modifier
        //2 type
        //3 name
        //4 getters --> read data /setter -->write

        //1     //2     //3    //4
        public string Make { get; set; }
        public string Model { get; set; }

        public double Milage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool isRunning { get; set; }
        public Indicator LeftIndicator { get; set; }

        public Indicator RightIndicator { get; set; }
        
        
        //Methods -> Actions...
        public void TurnOn()
        {
            isRunning = true;
            Console.WriteLine("You turned on the vehicle");

        }

        public void TurnOff()
        {
            isRunning = false;
            Console.WriteLine("You turned the vehicle off");
        }

        public override string ToString()
        {
            return $"{ Make} { Model} { Milage} {TypeOfVehicle}";
        }

        public class Indicator
        {
            //we want a bool isFlashing
            //you can only write to this w/n the 'scope' of this class
            public bool IsFlashing { get; private set; }

            //methods: TurnOn() TurnOff()
            //first method
            public void TurnOn()
            {
                IsFlashing = true;
                Console.WriteLine("Lights are on");
            }

            //second method
            public void TurnOff()
            {
                IsFlashing = false;
                Console.WriteLine("Lights are off");
            }

        }


    }
}
