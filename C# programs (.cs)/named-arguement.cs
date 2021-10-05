using System;

namespace C_Sharp
{
    class program
    {
        static void MyMethod(string child1, string child2, string child3) 
        {
            Console.WriteLine("The youngest child is " + child3);
        }

        static void Main(string[] args)
        {
            MyMethod(child2: "John", child1: "Liam", child3: "Chris");
        }
    }
}





// OUTPUT - The youngest child is Chris