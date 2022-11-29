namespace OOP_Inheritance_and_Polymorphism
{
    internal partial class Inheritance_and_Polymorphism
    {
        internal class CAR
        {
            //Private Fields
            private string Reg;
            private string Model;
            private string Colour;
            private string Make;
            private int NoOfWeels;

            //Construtctor
            public CAR(string reg, string colour, string model, string make, int noofweels)
            {
                Reg = reg;
                Model = model;
                Colour = colour;
                NoOfWeels = noofweels;
                Make = make;

            }

            //Setter/Mutator Method
            public void setRegistration(string registration)
            {
                if (registration.Length == 6)
                    this.Reg = registration;
            }
            //Getter/Accessor Method
            public string getRegistrations()
            {
                return this.Reg;
            }

            public void setModel(string model) //Setter/Mutator Method
            {
                this.Model = model;
            }

            public string getModel() //Getter/Accessor Method
            {
                return this.Model;
            }
            public void setColour(string colour) //Setter/Mutator Method
            {
                this.Colour = colour;
            }
            public string getColour() //Getter/Accessor Method
            {
                return this.Colour;
            }
            public void setMake(string make) //Setter/Mutator Method
            {
                this.Make = make;
            }
            public string getMake() //Getter/Accessor Method
            {
                return this.Make;
            }
            public void setNoOfWeels(int number) //Setter/Mutator Method
            {
                //Validation
                if (number >= 1 && number <= 6)//Range Check 
                    this.NoOfWeels = number;
            }
            public int getNoOfWeels() //Getter/Accessor Method
            {
                return this.NoOfWeels;
            }


            public override string ToString()
            {
                return
                    $"\n======================================" +
                    $"\nCar reg: {Reg}" +
                    $"\nCar colour: {Colour}" +
                    $"\nCar model: {Model}" +
                    $"\nCar make: {Make}" +
                    $"\nCar number of weels: {NoOfWeels}" +
                    $"\n======================================";
            }
        }
    }
}