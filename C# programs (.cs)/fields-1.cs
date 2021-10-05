using System;

namespace C_Sharp
{
    //You can also leave the fields blank, and modify them when creating the object:
    class Car
    {
        string color;
        int speed;

        static void Main(string[] args)
        {
            Car myObj= new Car();
            myObj.color= "red";
            myObj.speed= 100;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.speed);
        }
    }
}





// OUTPUT
//  red
//  100