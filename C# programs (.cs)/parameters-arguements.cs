using System;

namespace C_Sharp
{
    class program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Sharma");  // Added a litte space between " Sharma to get seperate fname and "sharma" 
        }

        static void Main(string[] args)
        {
            MyMethod("Shubham");
            MyMethod("SHUBHAM");
            MyMethod("sHuBhAm");
        }
    }
}





// OUTPUT 
//  Shubham Sharma
//  SHUBHAM Sharma
//  sHuBhAm Sharma