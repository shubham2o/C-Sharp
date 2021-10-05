using System;

namespace C_Sharp
{
    class Car
    {
        string color="red";
        static void Main(string[] args)
        {
            Car myobj = new Car();
            Console.WriteLine(myobj.color);
        }
    }
}