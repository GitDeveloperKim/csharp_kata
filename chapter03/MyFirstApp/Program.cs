using System;

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
        }


    }
}