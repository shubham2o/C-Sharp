using System;

namespace C_Sharp
{
    class program
    {
        static void MyMethod(string country= "Norway")
        {
            Console.WriteLine(country);
        }
        
        static void Main(string[] args)
        {
            MyMethod("India");
            MyMethod("Sweden");
            MyMethod();
            MyMethod("United States");
            MyMethod();
        }
    }
}





// OUTPUT
//  India
//  Sweden
//  Norway
//  United States
//  Norway