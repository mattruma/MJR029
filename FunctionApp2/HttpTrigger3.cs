using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp2
{
    public static class HttpTrigger3
    {
        [FunctionName("HttpTrigger3")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("HttpTrigger3 function processed a request.");

            var data =
                    await new StreamReader(req.Body).ReadToEndAsync();

            var queueClient =
                new QueueClient(
                    Environment.GetEnvironmentVariable("HttpTrigger3:ServiceBus:ConnectionString"),
                    Environment.GetEnvironmentVariable("HttpTrigger3:ServiceBus:Queue"));

            var message =
                new Message(Encoding.UTF8.GetBytes(data));

            await queueClient.SendAsync(
                message);

            return new OkObjectResult(data);
        }
    }
}
