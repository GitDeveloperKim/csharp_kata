using System.Collections;
using static System.Console;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // c# 6.0 >= 
            ArrayList a = null; 
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            // a가 null 이 더이상 아닙니다. 
            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}