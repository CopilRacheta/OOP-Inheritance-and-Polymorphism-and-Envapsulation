using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_and_Polymorphism
{
    internal static class CLI_Command_Line_Interface_
    {
        public static Garage garage { get; set; }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine($"\nWelcome to the {garage.Name}!");
            Console.WriteLine($"\n=============================");

            string Manage = Prompt.Select("Select your option ", new[] { "Manage Bookings", "Manage Drivers", "Manage Cares" });

            switch (Manage)
            {
                case "Manage Bookings":
                    manageBookings();
                    break;
                case "Manage Drivers":
                    manageDrivers();
                    break;
                case "Manage Cares":
                    manageCares();
                    break;
                default:
                    break;
            }

        }
        private static void manageBookings()
        {
            Console.WriteLine($"\nBooking Manager!");
            Console.WriteLine($"\n================");
            string Manage = Prompt.Select("Select your option ", new[] { "Add booking", "View booking", "Remove booking" });

            switch (Manage)
            {
                case "Add booking":

                    Console.Clear();
                    string registration = Prompt.Input<string>("Enter registration number: ");

                    Vehicle? vehicle = garage.GetVehicle(registration);

                    string type = Prompt.Input<string>("Enter type of service MOT/Repair: ");
                    DateTime data = new DateTime();
                    Booking booking = new Booking(vehicle, type,data);

                    garage.Booking.Add(booking);
                    Console.WriteLine($"\nThis is the booking add to the system: \n{booking}");

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();


                    MainMenu();

                    break;
                case "View booking":

                    Console.Clear();

                    foreach (var item in garage.Booking)
                    {
                        Console.WriteLine($"\nThe booking in the system: ");
                        Console.WriteLine(item);

                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();

                    MainMenu();

                    break;
                case "Remove booking":
                    Console.Clear();

                    string types = Prompt.Input<string>("Enter type of service: ");

                    Booking? currentBooking = garage.GetBooking(types);

                    if (currentBooking != null)
                    {
                        garage.Booking.Remove(currentBooking);
                        Console.WriteLine($"\nDriver Removed");
                    }
                    else
                    {
                        Console.WriteLine($"\nDriver not found");
                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();


                    MainMenu();
                    break;
                default:
                    break;
            }


            }
        private static void manageDrivers()
        {
            Console.WriteLine($"\nDriver Manager!");
            Console.WriteLine($"\n===============");
            string Manage = Prompt.Select("Select your option ", new[] { "Add New Driver", "View Driver", "Delete Driver" });
            switch (Manage)
            {
                case "Add New Driver":
                    //Prompt user to INPUT string licenceNumber , string name ,int age , string address
                    //Create a new Driver object using input details
                    //Add driver object to garage,Driver
                    //Go back to MainMenu
                    Console.Clear();

                    string licenceNumber = Prompt.Input<string>("What is you licenceNumber?");
                    string name = Prompt.Input<string>("What's your name?");
                    string address = Prompt.Input<string>("What's your address?");
                    string age = Prompt.Input<string>("What's your age?");

                    Driver Driver = new Driver(name, age, address, licenceNumber);

                    garage.Drivers.Add(Driver);

                    Console.WriteLine($"\nThis is the driver add to the system: \n{Driver}");

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();
                    

                    MainMenu();

                    break;

                case "View Driver":

                    Console.Clear();

                    foreach (var item in garage.Drivers)
                    {
                        Console.WriteLine($"\nThe driveres in the system: ");
                        Console.WriteLine(item);

                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();

                    MainMenu();


                    break;
                case "Delete Driver":

                    Console.Clear();

                    string licence = Prompt.Input<string>("Enter licence number: ");

                    Driver? driver = garage.GetDriver(licence);

                    if (driver != null)
                    {
                        garage.Drivers.Remove(driver);
                        Console.WriteLine($"\nDriver Removed");
                    }
                    else
                    {
                        Console.WriteLine($"\nDriver not found");
                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();


                    MainMenu();


                    break;

                default:
                    break;
            }
        }
        private static void manageCares()
        {
            Console.WriteLine($"\nCares Manager!");
            Console.WriteLine($"\n==============");

            string Manage = Prompt.Select("Select your option ", new[] { "Add car", "View car", "Remove car" });

            switch (Manage)
            {
                case "Add car":

                    Console.Clear();
                    string licence = Prompt.Input<string>("Enter licence number: ");

                    Driver? driver = garage.GetDriver(licence);

                    if (driver != null)
                    {
                        string registration = Prompt.Input<string>("Enter your registration number: ");
                        string modle = Prompt.Input<string>("Enter your car model: ");
                        string make = Prompt.Input<string>("Enter your cae make: ");
                        string colour = Prompt.Input<string>("Enter your car colour: ");
                        int numberOfWheels = Prompt.Input<int>("Enter your car number of wheels: ");

                        Vehicle vehicle = new Vehicle(registration, modle, make, colour, driver, numberOfWheels);

                        garage.Vehicle.Add(vehicle);

                        Console.WriteLine($"\nThis is the car add to the system: \n{vehicle}");
                    }
                    else
                    {
                        Console.WriteLine($"\nCar not found");
                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();


                    MainMenu();

                    break;
                case "View car":
                    Console.Clear();

                    foreach (var item in garage.Vehicle)
                    {
                        Console.WriteLine($"\nThe driveres in the system: ");
                        Console.WriteLine(item);

                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();

                    MainMenu();
                    break;
                case "Remove car":
                    Console.Clear();

                    string register = Prompt.Input<string>("Enter licence number: ");

                    Vehicle? currentcar = garage.GetVehicle(register);

                    if (currentcar != null)
                    {
                        garage.Vehicle.Remove(currentcar);
                        Console.WriteLine($"\nDriver Removed");
                    }
                    else
                    {
                        Console.WriteLine($"\nDriver not found");
                    }

                    Console.WriteLine($"\nPress any key to go back to main menu");
                    Console.ReadLine();


                    MainMenu();
                    break;
                default:
                    break;
            }
        }


        // C R/V U D

        //CREAT
        //READ/VIEW
        //UPDATE
        //Delete
    }
}
