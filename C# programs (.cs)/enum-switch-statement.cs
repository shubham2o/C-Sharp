using System;

namespace C_Sharp
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }

        static void Main(string[] args)
        {
            Level myVar= Level.Medium;
            switch(myVar)
            {
                case Level.Low:
                Console.WriteLine("Low Level");
                break;

                case Level.Medium:
                Console.WriteLine("Medium Level");
                break;

                case Level.High:
                Console.WriteLine("High Level");
                break;
            }
        }
    }
}





// OUTPUT - Medium level