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

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Booking> Booking { get => booking; set => booking = value; }

        public Garage(
            string name,
            string address
            )
        {
            Name = name;
            Address = address;
            Booking = new List<Booking>();
        }
    }
}