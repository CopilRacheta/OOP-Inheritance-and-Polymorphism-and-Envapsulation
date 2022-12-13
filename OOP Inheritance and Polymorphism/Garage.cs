using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Inheritance_and_Polymorphism
{
    internal class Garage
    {
        private string name;
        private string address;
        private List<Booking> booking;
        private List<Driver> drivers;
        private List<Vehicle> vehicle;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Booking> Booking { get => booking; set => booking = value; }

        public List<Driver> Drivers { get=>drivers ; set=>drivers=value ; }
        public List<Vehicle> Vehicle { get=> vehicle; set=> vehicle = value ; }

        public Garage(
            string name,
            string address
            )
        {
            Name = name;
            Address = address;
            Booking = new List<Booking>();
            Drivers = new List<Driver>();
            vehicle = new List<Vehicle>();
        }

        public Driver GetDriver(string licence)
        {
            foreach (var driver in Drivers)
            {
                if (driver.LicenceNumber == licence)
                {
                   return driver;
                }

            }
            return null;
        }

        public Vehicle GetVehicle(string registration)
        {
            foreach(var vehicle in Vehicle)
            {
                if(vehicle.Registration == registration)
                {
                    return vehicle;
                }
            }
            return null ;
        }

        public Booking GetBooking(string type)
        {
            foreach (var booking in Booking)
            {
                if (booking.Type == type)
                {
                   return booking;
                }
            }
            return null;
        }
    }
}