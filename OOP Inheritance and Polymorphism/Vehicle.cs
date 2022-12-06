using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_and_Polymorphism
{
    internal class Vehicle
    {

        private string registration;
        private string model;
        private string make;
        private string colour;
        private int noOfWheels;
        private Driver driver;//This is aggregation

        //Auto-gen Properties
        public string Registration { get => registration; set => registration = value; }//use prop tab tab to create this line of code
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public string Colour { get => colour; set => colour = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public int NoOfWheels
        {
            get => noOfWheels;
            set
            {
                if (value > 0 && value < 8)
                {
                    noOfWheels = value;
                }
            }
        }

        public Vehicle(
            string registration,
            string model,
            string make,
            string colour,
            Driver driver,
            int noOfWheels)
        {
            Registration = registration;
            Model = model;
            Make = make;
            Colour = colour;
            Driver = driver;
            NoOfWheels = noOfWheels;
        }

        public override string? ToString()
        {
            return
                $"\n======================================" +
                $"\nCar registration: {registration}" +
                $"\nCar colour: {colour}" +
                $"\nCar model: {model}" +
                $"\nCar make: {make}" +
                $"\nCar number of wheels: {noOfWheels}" +
                $"\n======================================" +
                $"\nCar driver: {driver}";
        }
    }
}
