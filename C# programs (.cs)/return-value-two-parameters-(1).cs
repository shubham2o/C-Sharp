using System;

namespace C_Sharp
{
    class result
    {
        //You can also store the result in a variable 
        //(recommended, as it is easier to read and maintain):
        static int MyResult(int x, int y)
        {
            return x = y;
        }

        static void Main(string[] args)
        {
            int z= MyResult(5, 10);
            Console.WriteLine(z);
        }
    }
}