using System;

namespace OOP_Inheritance_and_Polymorphism
{
    internal partial class Inheritance_and_Polymorphism
    {
        static void Main(string[] args)
        {

            //Encapsulation is the procces to make sure that the classes are able to edit data within a class

            // using cw and tab tab will create Console.WriteLine();

            //Using Car Class
            CAR myCar = new CAR("ASHD32", "Green", "Alpha", "Romeo", 4);
            Console.WriteLine(myCar);

            myCar.setRegistration("-21312");
            myCar.setColour("Blue");
            myCar.setModel("Bingo");
            myCar.setMake("BMW");
            myCar.setNoOfWeels(8);
            Console.WriteLine(myCar);


            //Using Vehicle Class
            Vehicle truck = new Vehicle("ASFIH2", "M4", "BMW", "Black", 4);
            Console.WriteLine(truck);
            truck.Registration = "SGEW12";
            truck.Model = "M2";
            truck.Make = "Audi";
            truck.Colour = "Red";
            truck.NoOfWheels = 5;
            Console.WriteLine(truck);


            //Using Van Class
            Van va1 = new Van("REGS12", "v1", "volvo", "Silver", 4);
            Console.WriteLine(va1);
        }

    }
}