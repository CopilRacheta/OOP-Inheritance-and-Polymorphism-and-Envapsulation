using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Inheritance_and_Polymorphism
{
    internal class Booking
    {

        private Guid id;
        private Vehicle car;
        private string type;
        private DateTime date;


        public Guid ID { get=>id; set=>id=value; }
        public Vehicle Car { get=>car; set=>car=value; }
        public string Type { get=>type; set=>type=value; }
        public DateTime Date { get=>date; set=>date=value; }

        public Booking(
            Vehicle car, 
            string type, 
            DateTime date)
        {
            ID = Guid.NewGuid();
            Car = car;
            Type = type;
            Date = date;
        }


        public override string? ToString()
        {
            return
                $"\n======================================" +
                $"\nBooking ID: {id}" +
                $"\nCar : {car}" +
                $"\nBooking type: {type}" +
                $"\nBooking date and time: {date}" +
                $"\n======================================";
        }
    }

}