using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNum = {1, 2, 3};
                Console.WriteLine(myNum[10]);
            }

            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished");
            }
        }
    }
}





// OUTPUT
//  Something went wrong.
//  The 'try catch' is finished