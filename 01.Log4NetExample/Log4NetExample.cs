[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace log4net
{
    using System;
    using log4net;
    
    public class Log4NetExample
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetExample));

        public static void Main()
        {            
            Log.Debug("Test Debug message");
            Log.Error("Test Error message");
            Console.WriteLine("Log messages successfully saved in Debug/log.txt");   
        }
    }
}
