using System;
namespace C_Sharp

{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be atleast 18 years old.");
            }

            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
        }
    }
}





// OUTPUT
//    Error: Specified file could not be executed.
//    Access denied - You must be atleast 18 years old.

// If age was 20, you would not get an exception:
// checkAge(20);
// OUTPUT
//    Access granted - You are old enough!