namespace OOP_Inheritance_and_Polymorphism
{
    internal class Motorbick : Vehicle
    {
        public Motorbick(string registration, string model, string make, string colour, Driver driver)
        : base(registration, model, make, colour, driver, 2)
        {

        }
    }
}