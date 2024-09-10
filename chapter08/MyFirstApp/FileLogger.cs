class FileLogger : ILogger
{
    private StreamWriter writer;

    public FileLogger(string path)
    {
        writer = File.CreateText(path);
        writer.AutoFlush = true;
    }

    public void WriteLog(string message)
    {
        writer.WriteLine("{0}", message);
    }
}