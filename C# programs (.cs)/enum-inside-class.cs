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
            Console.WriteLine(myVar);
        }
    }
}





// OUTPUT - Medium