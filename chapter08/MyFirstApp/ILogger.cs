interface ILogger{
    void WriteLog(string message);
    void WriteError(string error)
    {
        Console.WriteLine($"{error}");
    }
}