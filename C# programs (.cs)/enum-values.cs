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
            int myNum=(int) Months.April;   // To get the integer value from an item, you must explicitly convert the item to an int:
            Console.WriteLine(myNum);
        }
    }
}





// OUTPUT - 3