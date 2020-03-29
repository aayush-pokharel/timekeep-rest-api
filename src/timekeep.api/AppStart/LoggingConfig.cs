using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace timekeep.api.AppStart
{
    public class LoggingConfig
    {
        public static void Configure(Microsoft.Extensions.Hosting.HostBuilderContext context, ILoggingBuilder builder)
        {
            builder.AddConfiguration(context.Configuration.GetSection("Logging"));
            builder.AddEventSourceLogger();
            builder.AddConsole();
        }
    }
}
