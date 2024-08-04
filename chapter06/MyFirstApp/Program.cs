using System;
using static System.Console;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // call by reference example
            int x = 3;
            int y = 4;

            WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y); // ref 키워드와 함께 전달해야한다 
            WriteLine($"x:{x}, y:{y}");

            // out example
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a,b,out int c, out int d); // 초기화 하지 않아도 컴파일러가 호출 당하는 메소드에서 그 지역 변수를 할당할 것을 보장 
            WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }

        // 참조형 매개변수 주목 pass by reference
        static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a/b;
            remainder = a%b;
        }
    }
}