using System;
using System.Linq;

namespace C_Sharp
{
    class program
    {
        static void Main(string[] args)
        {
            int[] myNum= {0,1,45,90,22,7,18};
            Console.WriteLine(myNum.Max());             // returns the largest value
            Console.WriteLine(myNum.Min());             // returns the Lowest value
            Console.WriteLine(myNum.Sum());             // returns the sum of elements
        }
    }
}





// OUTPUT
//  90
//  0
//  183