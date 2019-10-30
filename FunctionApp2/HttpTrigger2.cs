using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace FunctionApp2
{
    public static class HttpTrigger2
    {
        [FunctionName("HttpTrigger2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log,
            [ServiceBus("%HttpTrigger2:ServiceBus:Topic%", Connection = "HttpTrigger2:ServiceBus:ConnectionString")] IAsyncCollector<string> messages)
        {
            log.LogInformation("HttpTrigger2 function processed a request.");

            var data =
                JsonConvert.DeserializeObject(
                    await new StreamReader(req.Body).ReadToEndAsync());

            await messages.AddAsync(
                JsonConvert.SerializeObject(data, Formatting.Indented));

            return new OkObjectResult(data);
        }
    }
}
