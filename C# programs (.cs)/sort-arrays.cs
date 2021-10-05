using System;

namespace C_Sharp
{
    class program
    {
        static void Main(string[] args)
        {
            // Sort a String array
            string[] cars= {"Volvo", "BMW", "Mercedes", "Tesla"};
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNum={2,5,6,1,9,7,20,12,4};
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}





// OUTPUT
//  BMW
//  Mercedes
//  Tesla
//  Volvo
//  1
//  2
//  4
//  5
//  6
//  7
//  9
//  12
//  20