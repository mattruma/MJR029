using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public static class HttpServiceBusTopicTrigger1
    {
        [FunctionName("HttpServiceBusTopicTrigger1")]
        public static void Run(
            [ServiceBusTrigger("%HttpServiceBusTopicTrigger1:ServiceBus:Topic%", "%HttpServiceBusTopicTrigger1:ServiceBus:Subscription%", Connection = "HttpServiceBusTopicTrigger1:ServiceBus:ConnectionString")]string message,
            ILogger log)
        {
            log.LogInformation("HttpServiceBusTopicTrigger1 function processed a request.");

            log.LogInformation(message);
        }
    }
}
