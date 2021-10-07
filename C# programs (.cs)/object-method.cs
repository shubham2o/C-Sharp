using System;

namespace C_Sharp
{
    class Car
    {
        string color;                   // field
        string maxSpeed;                // field
        public void fullThrottle()      // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myobj= new Car();
            myobj.fullThrottle();       // Call the method
        }
    }
}





// OUTPUT - The car is going as fast as it can!