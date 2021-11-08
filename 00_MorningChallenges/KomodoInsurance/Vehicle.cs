using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges.KomodoInsurance
{
    public enum VehicleType { Sedan, Truck, Van, Motorcycle, SUV, SportsCar}
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;


        }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public bool IsRunning { get; set; }
        public bool IsMoving { get; set; }
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You started the enging");
        } 

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turnd the engine off");
        }
        public void Drive()
        {
            IsMoving = true;
            Console.WriteLine("You are driving the vehicle");
        }
        

    }
}
