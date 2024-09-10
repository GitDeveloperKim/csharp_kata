class ClimateMonitor
{
    private ILogger logger;
    public ClimateMonitor(ILogger logger)
    {
        this.logger = logger;
    }

    public void start()
    {
        while(true)
        {
            Console.Write("온도를 입력하시오");
            String temperature = Console.ReadLine();
            if (temperature == "")
                break;
            
            logger.WriteLog("현재 온도 : " + temperature);
        }
    }
}