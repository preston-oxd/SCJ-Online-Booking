using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

namespace SCJ.Booking.MVC.Services
{
    public static class LogHelper
    {
        public static ILogger GetLogger (IConfiguration configuration)
        {
            // default log level is error (less verbose)
            var logLevel = LogEventLevel.Error;

            //check if this is running on a developer workstation (outside OpenShift)
            string tagName = configuration["TAG_NAME"] ?? "";
            if (tagName.ToLower().Equals("localdev"))
            {
                logLevel = LogEventLevel.Debug;
            }

            // check if this is the OpenShift development environment
            if (tagName.ToLower().Equals("dev"))
            {
                logLevel = LogEventLevel.Information;
            }

            //setup error logger settings
            return new LoggerConfiguration()
                .WriteTo.Console(logLevel)
                .CreateLogger();
        }
    }
}
