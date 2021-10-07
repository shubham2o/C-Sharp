using System;

namespace C_Sharp
{
    class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July
        }

        static void Main(string[] args)
        {
            int myNum=(int) Months.April;
            Console.WriteLine(myNum);
        }
    }
}





// OUTPUT - 3