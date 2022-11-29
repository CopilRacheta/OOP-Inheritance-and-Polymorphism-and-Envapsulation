using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_and_Polymorphism
{
    internal class Vehicle
    {
        //Auto-gen Properties
        public string Registration { get; set; }//use prop tab tab to create this line of code
        public string Model { get; set; }
        public string Make { get; set; }
        public string Colour { get; set; }
        public int NoOfWheels { get; set; }

        public Vehicle(string registration, string model, string make, string colour, int noOfWheels)//Using control and . and then you can select create constructor
        {
            Registration = registration;
            Model = model;
            Make = make;
            Colour = colour;
            NoOfWheels = noOfWheels;
        }

        public override string ToString()
        {
            return
                $"\n======================================" +
                $"\nCar reg: {Registration}" +
                $"\nCar colour: {Colour}" +
                $"\nCar model: {Model}" +
                $"\nCar make: {Make}" +
                $"\nCar number of weels: {NoOfWheels}" +
                $"\n======================================";
        }
    }
}
