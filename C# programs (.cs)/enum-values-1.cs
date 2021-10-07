using System;

namespace C_Sharp
{
    class Program
    {
        enum Months
        {
            January,    // 0
            February1,  // 1
            March = 6,  // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        static void Main(string[] args)
        {
            int myNum= (int) Months.April;
            Console.WriteLine(myNum);
        }
    }
}





// OUTPUT - 7