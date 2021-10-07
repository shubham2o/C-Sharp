using System;

namespace C_Sharp
{
    interface IFirstInterface
    {
        void myMethod();    // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod();   // interface method
    }

    // implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myobj = new DemoClass();
            myobj.myMethod();
            myobj.myOtherMethod();
        }
    }
}





// OUTPUT
//  Some text...
//  Some other text...