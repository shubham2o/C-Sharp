using System;

namespace C_Sharp
{
    class Car
    {
        string color = "red";
        int maxspeed = 100;
        static void Main(string[] args)
        {
            Car Myobj1= new Car();
            Car Myobj2= new Car();
            Console.WriteLine(Myobj1.color);
            Console.WriteLine(Myobj2.maxspeed);
        }
    }
}





// OUTPUT
//  red
//  100