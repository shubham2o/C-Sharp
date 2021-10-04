using System;

namespace C_Sharp
{
    class program
    {
        static void Main(string[] args)
        {
            string[] cars={"Volvo", "BMW", "Mercedes", "Tesla"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}





// OUTPUT 
//  Volvo
//  BMW
//  Mercedes
//  Tesla