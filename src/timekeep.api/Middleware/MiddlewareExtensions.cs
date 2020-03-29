using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace timekeep.api.Middleware
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Global request handler
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseGlobalHandler(this IApplicationBuilder builder) =>
            builder.UseMiddleware<GlobalHandler>();
    }
}
