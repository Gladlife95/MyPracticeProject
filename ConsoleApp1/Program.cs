using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your name:");
            input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!");
            Console.WriteLine("Goodbye, " + input + ".");
        }
    }
}
