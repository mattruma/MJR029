using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public static class HttpServiceBusQueueTrigger1
    {
        [FunctionName("HttpServiceBusQueueTrigger1")]
        public static void Run(
            [ServiceBusTrigger("%HttpServiceBusQueueTrigger1:ServiceBus:Queue%", Connection = "HttpServiceBusQueueTrigger1:ServiceBus:ConnectionString")]string message,
            ILogger log)
        {
            log.LogInformation("HttpServiceBusQueueTrigger1 function processed a request.");

            log.LogInformation(message);
        }
    }
}
