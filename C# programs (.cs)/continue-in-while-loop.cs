using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i<10)
            {
                if (i==4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
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