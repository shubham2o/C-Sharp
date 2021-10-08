using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int[] myNumbers = {1,2,3};
                Console.WriteLine(myNumbers[10]);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}





// OUTPUT - Index was outside the bounds of the array.