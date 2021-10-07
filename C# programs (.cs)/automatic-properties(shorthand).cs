using System;

namespace C_Sharp
{
    class Person
    {
        public string Name      // property name
        {get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj= new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}





// OUTPUT - Liam