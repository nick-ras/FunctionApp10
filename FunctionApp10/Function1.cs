using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp10
{
    public class Functions
    {
        private readonly ILogger _logger;

        public Functions(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Functions>();
        }

        [Function("Function1ByNick")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, 
            "get", "post", Route = "walkthrough")] 
        HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request!");

            var response = req.CreateResponse(HttpStatusCode.OK);
          
           await response.WriteAsJsonAsync(new
            {
                Name = "azure function",
                currenttime = DateTime.Now.ToString()
            });

            return response;
        }
    }
}
