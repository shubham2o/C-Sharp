using System;

namespace C_Sharp
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myanimal = new Animal();
            Animal mypig = new Pig();
            Animal  mydog = new Dog();

            myanimal.animalSound();
            mypig.animalSound();
            mydog.animalSound();
        }
    }
}





// OUTPUT
//  The animal make a sound
//  The pig says: wee wee
//  The dog says: bow bow