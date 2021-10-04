using System;

namespace C_Sharp
{
    class program 
    {
        static void Main(string[] args)
        {
            string[] cars= {"Volvo", "BMW", "Mercedes", "Tesla"};
            for (int i=0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}





//  OUTPUT 
//   Volvo
//   BMW
//   Mercedes
//   Tesla