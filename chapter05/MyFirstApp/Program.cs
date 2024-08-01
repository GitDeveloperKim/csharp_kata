using System;
using static System.Console;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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
                    break; // c# 은 반드시 break문을 써주어야 한다 
                case float f when f>=0: // 케이스 가드
                    WriteLine($"{(float)obj}는 float 양의 형식입니다.");
                    break;
                case float: // 케이스 가드
                    WriteLine($"{(float)obj}는 float 음의 형식입니다.");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }

            int[] arr = new int[]{0,1,2,3,4};

            foreach (int a in arr)
            {
                WriteLine(a);
            }

            // 선언 패턴
            object foo =23;
            if (foo is int bar) // foo 가 int 형식이면 foo를 int형식으로 변환하여 bar에 할당
            {
                WriteLine(bar);
            }
            // 형식 패턴 
            // 상수 패턴 
            // 프로퍼티 패턴 
            // 관계 패턴 
            // 논리 패턴 
            // 괄호 패턴 
            // 위치 패턴 
            // var 패턴 
            // 무시 패턴 
            // 목록 패턴 
        }
    }
}