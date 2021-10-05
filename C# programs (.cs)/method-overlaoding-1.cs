using System;

namespace C_Sharp
{
    class programs
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum=PlusMethod(8,5);
            double myNum1=PlusMethod(4.4,6.6);
            Console.WriteLine("int - " + myNum);
            Console.WriteLine("double - " + myNum1);
        }
    }
}





// OUTPUT
//  int - 13
//  double - 11m