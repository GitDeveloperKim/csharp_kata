using System.Collections;
using static System.Console;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // c# 6.0 >= 
            // chapter 4.8 엘비스 연산자 
            ArrayList a = null; 
            a?.Add("야구");
            a?.Add("축구");

            // a는 null 이므로 아무것도 반환하지 않는다
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

            // chapter 4.11 null 병합 연산자 
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");

            // switch pattern matching 
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i)) // TryParse Method 
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;
            
            switch (obj)
            {
                case int:
                    WriteLine($"{(int)obj}는 int 형식입니다.");
                    break;
                case float:
                    WriteLine($"{(float)obj}는 float 형식입니다.");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}