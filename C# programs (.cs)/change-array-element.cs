using System;

namespace C_Sharp
{
    class program
    {
        static void Main(string[] args)
        {
            string[] cars= {"Volvo", "BMW", "Ford", "Mercedes", "Audi"};
            cars[0]= "Tesla";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
        }
    }
}





//   OUTPUT
//   Tesla
//   BMW