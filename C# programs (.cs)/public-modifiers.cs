using System;

namespace C_Sharp
{
    class Car
    {
        public string model = "Mustang";
    }

    class program
    {
        static void Main(string[] args)
        {
            Car myObj= new Car();
            Console.WriteLine(myObj.model);
        }
    }
}





// OUTPUT - Mustang