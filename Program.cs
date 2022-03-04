// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            if (args.Length == 1) 
            {
                Console.WriteLine($"Hello, {args[0]}");
            }
            else 
            {
                Console.WriteLine($"Hello, World");
            }
            
        }
    }
}
