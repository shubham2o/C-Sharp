// If you don't want other classes to inherit from a class, use the sealed keyword:
using System;

namespace C_Sharp
{
    sealed class Vehicle
    {
        
        public string brand= "Ford";    // Vehicle  field
        public void honk()              // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the vehicle class) on the object
            myCar.honk();

            //Display the value of the brand field (from the vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}





// OUTPUT 
// error CS0509:  'Car': cannot derive from sealed type 'Vehicle'