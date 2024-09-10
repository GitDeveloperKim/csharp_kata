using System;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            monitor.start();
        }

        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}