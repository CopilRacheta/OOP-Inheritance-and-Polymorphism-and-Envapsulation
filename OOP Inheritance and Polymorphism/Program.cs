using System;

namespace OOP_Inheritance_and_Polymorphism
{
    internal partial class Inheritance_and_Polymorphism
    {
        static void Main(string[] args)
        {


            CLI_Command_Line_Interface_.garage = new Garage("Mihai garage", "5 Street");
            CLI_Command_Line_Interface_.MainMenu();












            /*//Encapsulation is the procces to make sure that the classes are able to edit data within a class

            // using cw and tab tab will create Console.WriteLine();

            //Using Cars Class
            
            CAR myCar = new CAR("ASHD32", "Green", "Alpha", "Romeo", -1);
            Console.WriteLine(myCar);
            myCar.setRegistration("-21312");
            myCar.setColour("Blue");
            myCar.setModel("Bingo");
            myCar.setMake("BMW");
            myCar.setNoOfWeels(12);
            Console.WriteLine(myCar);
            

            //Using Driver Class
            Driver f1 = new Driver("Ben", "28", "42BET", "98427582934724");
            Console.WriteLine(f1);

            //Using Vehicle Class
            
            Vehicle truck = new Vehicle("ASFIH2", "M4", "BMW", "Black",f1,4);
            Console.WriteLine(truck);
            truck.Registration = "SGEW12";
            truck.Model = "M2";
            truck.Make = "Audi";
            truck.Colour = "Red";
            truck.NoOfWheels = 5;
            truck.Driver = f1;
            Console.WriteLine(truck);
            

            //Using Van Class
            Car car1 = new Car("REGS12", "v1", "volvo", "Silver", f1);
            Console.WriteLine(car1);

            //Using Motorbick
            Motorbick motorbick = new Motorbick("FAHI21", "A23", "BMW", "RED", f1);
            Console.WriteLine(motorbick);

            //Using Booking Class                              //Y    M   D   H   m  s
            Booking b1 = new Booking(car1, "MOT", new DateTime(2022, 12, 14, 12, 0, 0));
            Console.WriteLine(b1);

            Booking b2 = new Booking(motorbick, "Repair", new DateTime(2022, 12, 15, 9, 0, 0));
            Console.WriteLine(b2);

            //Using Garage Class
            Garage g1 = new Garage("Repai and MOT", "21412saf");
            g1.Booking.Add(b1);//Adding Booking Class to Garage Class
            g1.Booking.Add(b2);

            foreach (var booking in g1.Booking)//Displaying Garage Bookings
            {
                Console.WriteLine(booking);
            }
            */
            

            
        }
    }


}