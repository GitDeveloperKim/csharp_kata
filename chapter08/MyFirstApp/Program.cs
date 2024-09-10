using System;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("log.txt"));
            monitor.start();

            ILogger logger = new ConsoleLogger(); // ILogger 로 참조했을때만 기본 함수 사용 가능 
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            // clogger.WriteError("System Fail"); // 컴파일 에러 ConsoleLogger 에서 오버라이딩 구현 해야함 
        }

        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}