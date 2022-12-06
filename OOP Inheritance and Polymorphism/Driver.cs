using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Inheritance_and_Polymorphism
{
    internal class Driver
    {

        private string name;
        private string age;
        private string address;
        private string licenceNumber;

        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string LicenceNumber
        {
            get => licenceNumber;
            set
            {
                if (value.Length > 0 && value.Length < 16)
                {
                    licenceNumber = value;
                }
            }

        }

        public Driver(string name, string age, string address, string licenceNumber)
        {
            Name = name;
            Age = age;
            Address = address;
            LicenceNumber = licenceNumber;
        }

        public override string? ToString()
        {
            return
                $"\n======================================" +
                $"\nDriver name: {name}" +
                $"\nDiver age: {age}" +
                $"\nDriver address: {address}" +
                $"\nDriver licence number: {licenceNumber}" +
                $"\n======================================";
        }
    }
}