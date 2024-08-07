using System;

namespace MyFirstApp
{
    public class Program
    {
        class MyClass 
        {
            int a, b, c;

            public MyClass()
            {
                this.a = 5425;
                PrintFields();
            }

            public MyClass(int b) : this()
            {
                this.b = b;
                PrintFields();
            }

            public MyClass(int b, int c) : this(b)
            {
                this.c = c;
                PrintFields();
            }

            public void PrintFields()
            {
                Console.WriteLine($"a:{a}, b:{b}, c:{c}");
            }
        }

        class MyName 
        {
            protected string Name;
            public MyName(string Nme) 
            {
                this.Name = Name;
                Console.WriteLine($"MyName {this.Name}");
            }
        }

        class OurName : MyName
        {
            public OurName(string Name) : base(Name) 
            {
                Console.WriteLine($"OurName {this.Name}");
            }
        }
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            
            MyClass b = new MyClass(1);

            MyClass c = new MyClass(10,20);

            MyName d = new MyName("Nick");

            MyName e = new OurName("David");
        }
    }
}