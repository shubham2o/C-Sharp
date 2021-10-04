using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                if (i==4)
                {
                    continue;
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
//   5
//   6
//   7
//   8
//   9