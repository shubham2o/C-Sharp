using System;

namespace C_Sharp
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelname, string modelcolor, int modelyear)
        {
            model = modelname;
            color = modelcolor;
            year = modelyear;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 2000);
            Console.WriteLine(Ford.model + " " + Ford.color + " " + Ford.year);
        }
    }
}





// OUTPUT
//  Mustang Red 2000