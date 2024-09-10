class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0}", message);
    }
}