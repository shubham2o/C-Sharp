using System;

namespace C_Sharp
{
    class program
    {
        static void MyMethod (string fname, int age)
        {
            Console.WriteLine(fname + " is " + age + " years old.");
        }

        static void Main(string[] args)
        {
            MyMethod("Shubham", 21);
        }
    }
}





// OUTPUT - Shubham is 21 years old.