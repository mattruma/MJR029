using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public static class HttpServiceBusTopicTrigger2
    {
        [FunctionName("HttpServiceBusTopicTrigger2")]
        public static void Run(
            [ServiceBusTrigger("%HttpServiceBusTopicTrigger2:ServiceBus:Topic%", "%HttpServiceBusTopicTrigger2:ServiceBus:Subscription%", Connection = "HttpServiceBusTopicTrigger2:ServiceBus:ConnectionString")]string message,
            ILogger log)
        {
            log.LogInformation("HttpServiceBusTopicTrigger2 function processed a request.");

            log.LogInformation(message);
        }
    }
}
