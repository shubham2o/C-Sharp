using System;

namespace C_Sharp
{
    class Car
    {   
        //If you try to access it outside the class, an error will occur:
        private string model= "Mustang";

        static void Main(string[] args)
        {
            Car myObj= new Car();
            Console.WriteLine(myObj.model);
        }
    }
}





// OUTPUT - Mustang