using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + " welcome back, man!");
        }
    }
}
