using System;

namespace MyFirstApp
{
    public class Program
    {
        delegate int MyDelegate(int a, int b); // 대리자의 선언 

        class Calculator {
            public int Plus(int a, int b)
            {
                return a+b;
            }
            public int Minus(int a, int b) // 예시에는 Plus static int Minus(int a, int b) 도 된다고 나옴 오류
            {
                return a-b;
            }
        }

        delegate void Notify(string message); // deletegate 선언 

        class Notifier
        {
            public Notify EventOccured; // 선언된 delegate 변수 선언 
        }

        class EventListener
        {
            private string name;
            public EventListener(string name) 
            {
                this.name = name;
            }

            public void SomethingHappend(string message)
            {
                Console.WriteLine($"{name}.SomethingHappend : {message}");
            }
        }

        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback; // 형식의 이름으로 

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3,4));

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(7,5));

            // example2
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend; // something happend 대리 
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail");

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!");
        }
    }
}