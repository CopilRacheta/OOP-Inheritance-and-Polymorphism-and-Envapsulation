using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_and_Polymorphism
{
    internal class Van : Vehicle //Van inheritance from Vehicle
    {
        public Van(string registration, string model, string make, string colour, int noOfWheels) 
        : base(registration, model, make, colour, noOfWheels)
        {
        }
    }
}
