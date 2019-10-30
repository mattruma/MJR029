# Introduction

Demonstrates sending and receiving messages from a Service Bus queue or topic.

The `FunctionApp1` project is .NET Standard Framework - **COMING SOON**.

The `FunctionApp2` project is .NET Core.

The `local.settings.json` file should look as follows:

```
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "HttpTrigger1:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpTrigger1:ServiceBus:Queue": "SERVICE_BUS_QUEUE",
    "HttpTrigger2:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpTrigger2:ServiceBus:Topic": "SERVICE_BUS_TOPIC",
    "HttpTrigger3:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpTrigger3:ServiceBus:Queue": "SERVICE_BUS_QUEUE",
    "HttpTrigger4:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpTrigger4:ServiceBus:Topic": "SERVICE_BUS_TOPIC",
    "HttpServiceBusQueueTrigger1:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpServiceBusQueueTrigger1:ServiceBus:Queue": "SERVICE_BUS_QUEUE",
    "HttpServiceBusTopicTrigger1:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpServiceBusTopicTrigger1:ServiceBus:Topic": "SERVICE_BUS_TOPIC",
    "HttpServiceBusTopicTrigger1:ServiceBus:Subscription": "SERVICE_BUS_TOPIC_SUBSCRIPTION_1",
    "HttpServiceBusTopicTrigger2:ServiceBus:ConnectionString": "YOUR_SERVICE_BUS_CONNECTION_STRING",
    "HttpServiceBusTopicTrigger2:ServiceBus:Topic": "SERVICE_BUS_TOPIC",
    "HttpServiceBusTopicTrigger2:ServiceBus:Subscription": "SERVICE_BUS_TOPIC_SUBSCRIPTION_2"
  }
}
```

The `HttpTrigger1` writes to a Service Bus queue using output bindings.

The `HttpTrigger2` writes to a Service Bus topic using output bindings.

The `HttpTrigger3` writes to a Service Bus queue using the Service Bus SDK.

The `HttpTrigger4` writes to a Service Bus topic using the Service Bus SDK.

The `HttpServiceBusQueueTrigger1` reads from a Service Bus queue using input bindings.

The `HttpServiceBusTopicTrigger1` reads from a Service Bus topic through the subscription 1 using input bindings.

The `HttpServiceBusTopicTrigger2` reads from a Service Bus topic through the subscription 2 using input bindings.

