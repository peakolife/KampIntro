using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();
            myBird.animalSound();
            DemoClass myObject = new DemoClass();
            myObject.MyFirstIMethod();
            myObject.MySecondIMethod();
        }
    }
    // I'm creating our interface.
    interface IAnimal
    {
        void animalSound(); // interface method (doesnt have a body)
    }
    interface IMyFirstInterface
    {
        void MyFirstIMethod();
    }
    interface ISecondInterface
    {
        void MySecondIMethod();
    }
    class DemoClass : IMyFirstInterface, ISecondInterface
    {
        public void MyFirstIMethod()
        {
            Console.WriteLine("first method some text");
        }
        public void MySecondIMethod()
        {
            Console.WriteLine("my second method some text");
        }
    }
    class Bird : IAnimal
    {
        public void animalSound()
        {
            //body of animalSound provided here.
            Console.WriteLine("bird says: chip chip");
        } 
    }
}
