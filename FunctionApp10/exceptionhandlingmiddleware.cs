using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Middleware;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp10
{
    public class exceptionhandlingmiddleware : IFunctionsWorkerMiddleware
    {
        private readonly ILogger<exceptionhandlingmiddleware> _logger;
        public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "somthing went wront");
            }
        }
    }
}
