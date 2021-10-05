using System;

namespace C_Sharp
{
    class Car
    {
        //This is especially useful when creating multiple objects of one class:
        string model;
        string color;
        int year;

        static void Main(string[] args)
        {
            Car tesla= new Car();
            tesla.model= "ModelS";
            tesla.color= "BlackGrey";
            tesla.year= 2021;

            Car BMW =new Car();
            BMW.model= "i8";
            BMW.color= "Black";
            BMW.year= 2020;

            Console.WriteLine(tesla.model);
            Console.WriteLine(tesla.color);
            Console.WriteLine(tesla.year);
            Console.WriteLine(BMW.model);
            Console.WriteLine(BMW.color);
            Console.WriteLine(BMW.year);
        }
    }
}