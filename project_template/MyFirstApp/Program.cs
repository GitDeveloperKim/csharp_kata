using System;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}