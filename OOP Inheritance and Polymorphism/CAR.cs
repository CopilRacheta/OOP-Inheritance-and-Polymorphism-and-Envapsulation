using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_and_Polymorphism
{
    internal class Car : Vehicle //Van inheritance from Vehicle
    {
        public Car(string registration, string model, string make, string colour, Driver driver)
        : base(registration, model, make, colour, driver, 4)
        {
        }
    }
}
