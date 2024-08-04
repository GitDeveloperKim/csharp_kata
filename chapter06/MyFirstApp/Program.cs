using System;
using static System.Console;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y); // ref 키워드와 함께 전달해야한다 
            WriteLine($"x:{x}, y:{y}");

        }

        // 참조형 매개변수 주목 pass by reference
        static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}