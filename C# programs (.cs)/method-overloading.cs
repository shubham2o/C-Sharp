using System;

namespace C_Sharp
{
    class program
    {
        static int PlusMethodInt(int x, int y)
        {
            return x+y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x+y;
        }

        static void Main(string[] args)
        {
            int myNum1=PlusMethodInt(8,5);
            double myNum2=PlusMethodDouble(4.4,6.6);
            Console.WriteLine("int - " + myNum1);
            Console.WriteLine("double - " + myNum2);
        }
    }
}





// OUTPUT 
//  int - 13
//  double - 11