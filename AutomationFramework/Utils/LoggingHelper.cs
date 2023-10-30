
using System;
using Serilog;
using Serilog.Sinks.File;

namespace AutomationFramework.Helpers
{
	public class LoggingHelper
	{
        public static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt")
                .CreateLogger();
        }
    }
}

