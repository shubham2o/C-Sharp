using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good Morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good Day.");
            }
            else
            {
                Console.WriteLine("Good Evening.");
            }
        }
    }
}





// OUTPUT - Good Evening.