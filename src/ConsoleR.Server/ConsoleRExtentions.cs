using System;
using Microsoft.AspNet.Http;
using Microsoft.Framework.Internal;
using Microsoft.AspNet.Builder;
using ConsoleR.Server.Configuration;

namespace ConsoleR.Server
{
    public static class ConsoleRExtentions
    {
        public static IApplicationBuilder UseConsoleR(this IApplicationBuilder builder)
        {
            return builder.UseConsoleR(new ConsoleROptions());
        }

        public static IApplicationBuilder UseConsoleR(this IApplicationBuilder builder, ConsoleROptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            return builder;
        }
    }
}
