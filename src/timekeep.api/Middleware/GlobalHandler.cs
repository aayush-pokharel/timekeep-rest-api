using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace timekeep.api.Middleware
{
    public class GlobalHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalHandler> _logger;
        public GlobalHandler(RequestDelegate next, ILogger<GlobalHandler> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            //Add middleware logic here...

            await _next(context);
        }
    }
}
