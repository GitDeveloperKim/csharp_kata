using System;
using static System.Console; // console 사용 하는 문법인듯 

namespace MyFirstApp
{
    public class Program
    {
        enum RESPONSE_DATA {YES, NO, OK} // declare enum 

        static void Main(string[] args)
        {
            int a = int.Parse("12345"); // string to int 
            Console.WriteLine(a);

            int c = 12345;
            string d = c.ToString(); // int to string 
            Console.WriteLine(d);
            
            var e = new int[] {10,20,30}; // var type and array
            int? f = null; // nullable
            
            RESPONSE_DATA rd = RESPONSE_DATA.YES;
            Console.WriteLine(rd == RESPONSE_DATA.NO);

            // string format number 
            // D
            WriteLine("10진수: {0:D}", 123);
            
            // X
            WriteLine("16진수: 0x{0:X}", 0xFF1234);

            // N 
            WriteLine("숫자 : {0:N}", 123456789);

            // F
            WriteLine("고정 소수점 : {0:F}", 123.45);
        }


    }
}