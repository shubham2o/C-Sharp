using System;

namespace C_Sharp
{
    class Program{
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}





// OUTPUT
//   0
//   1
//   2
//   3