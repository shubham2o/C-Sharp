// You can also output your own error message:
using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}





// OUTPUT - Something went wrong.