using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class ServiceProviderCases
{
    [WorkflowCase("ServiceProviderBlobLiteral", "blob literal")]
    public static FlowDefinition BlobLiteral()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var container = ServiceProviderFixtures.ResourceName("ServiceProviderBlobLiteral");
        var upload = WorkflowActions.ServiceProviders.AzureBlob(ServiceProviderFixtures.BlobConnection)
            .UploadBlob(containerName: () => container, blobName: () => "value.txt", content: () => "blob literal").WithName("Upload");
        return FinishBlob("ServiceProviderBlobLiteral", trigger, container, upload);
    }

    [WorkflowCase("ServiceProviderBlobTemplate", "blob template")]
    public static FlowDefinition BlobTemplate()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var container = ServiceProviderFixtures.ResourceName("ServiceProviderBlobTemplate");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "blob template").WithName("Source");
        var upload = WorkflowActions.ServiceProviders.AzureBlob(ServiceProviderFixtures.BlobConnection)
            .UploadBlob(containerName: () => container, blobName: () => "value.txt", content: () => source.Output).WithName("Upload");
        return FinishBlob("ServiceProviderBlobTemplate", trigger, container, upload, source);
    }

    [WorkflowCase("ServiceProviderBlobNative", "BLOB NATIVE")]
    public static FlowDefinition BlobNative()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var container = ServiceProviderFixtures.ResourceName("ServiceProviderBlobNative");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "blob native").WithName("Source");
        var upload = WorkflowActions.ServiceProviders.AzureBlob(ServiceProviderFixtures.BlobConnection)
            .UploadBlob(containerName: () => container, blobName: () => "value.txt",
                content: () => source.Output.ToUpperInvariant()).WithName("Upload");
        return FinishBlob("ServiceProviderBlobNative", trigger, container, upload, source);
    }

    private static FlowDefinition FinishBlob(string name, IWorkflowTrigger trigger, string container,
        IBodyWorkflowAction<UploadBlobOutput> upload, params IWorkflowAction[] seeds)
    {
        var provider = WorkflowActions.ServiceProviders.AzureBlob(ServiceProviderFixtures.BlobConnection);
        var read = provider.ReadBlob(containerName: () => container, blobName: () => "value.txt",
            inferContentType: () => true).WithName("Read");
        var result = WorkflowActions.BuiltIn.Compose<JToken>(() => read.Body.Content).WithName("Result");
        var delete = provider.DeleteBlob(containerName: () => container, blobName: () => "value.txt").WithName("Delete");
        var absent = provider.BlobExists(containerName: () => container, blobName: () => "value.txt").WithName("AfterDelete");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response");
        IChainableNode chain = trigger;
        foreach (var seed in seeds) chain = chain.Then(seed);
        chain.Then(upload).Then(read).Then(result).Then(delete).Then(absent).Then(response);
        return WorkflowFactory.CreateStatefulWorkflow(name, trigger);
    }

    [WorkflowCase("ServiceProviderQueueLiteral", "queue literal")]
    public static FlowDefinition QueueLiteral()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var queue = ServiceProviderFixtures.ResourceName("ServiceProviderQueueLiteral");
        var send = WorkflowActions.ServiceProviders.Azurequeues(ServiceProviderFixtures.QueueConnection)
            .PutMessage(queueName: () => queue, message: () => "queue literal").WithName("Send");
        return FinishQueue("ServiceProviderQueueLiteral", trigger, queue, send);
    }

    [WorkflowCase("ServiceProviderQueueTemplate", "queue template")]
    public static FlowDefinition QueueTemplate()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var queue = ServiceProviderFixtures.ResourceName("ServiceProviderQueueTemplate");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "queue template").WithName("Source");
        var send = WorkflowActions.ServiceProviders.Azurequeues(ServiceProviderFixtures.QueueConnection)
            .PutMessage(queueName: () => queue, message: () => source.Output).WithName("Send");
        return FinishQueue("ServiceProviderQueueTemplate", trigger, queue, send, source);
    }

    [WorkflowCase("ServiceProviderQueueNative", "QUEUE NATIVE")]
    public static FlowDefinition QueueNative()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var queue = ServiceProviderFixtures.ResourceName("ServiceProviderQueueNative");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "queue native").WithName("Source");
        var send = WorkflowActions.ServiceProviders.Azurequeues(ServiceProviderFixtures.QueueConnection)
            .PutMessage(queueName: () => queue, message: () => source.Output.ToUpperInvariant()).WithName("Send");
        return FinishQueue("ServiceProviderQueueNative", trigger, queue, send, source);
    }

    private static FlowDefinition FinishQueue(string name, IWorkflowTrigger trigger, string queue,
        IOutputWorkflowAction<PutMessageOutput> send, params IWorkflowAction[] seeds)
    {
        var provider = WorkflowActions.ServiceProviders.Azurequeues(ServiceProviderFixtures.QueueConnection);
        var create = provider.PutQueue(queueName: () => queue).WithName("CreateQueue");
        var received = WorkflowActions.BuiltIn.Variables.InitializeVariable(
            name: () => "received", value: () => "").WithName("InitializeReceived");
        var read = provider.GetMessages(queueName: () => queue, messageCount: () => 1,
            visibilityTimeout: () => "00:00:30").WithName("Read");
        var consume = WorkflowActions.BuiltIn.Control.ForEach(items: () => read.Body, actions: item =>
        {
            var capture = WorkflowActions.BuiltIn.Variables.SetVariable(
                name: () => "received", value: () => item["content"].Value<string>()).WithName("Capture");
            var delete = provider.DeleteMessage(queueName: () => queue,
                messageId: () => item["messageId"].Value<string>(),
                popReceipt: () => item["popReceipt"].Value<string>()).WithName("Delete");
            return capture.Then(delete);
        }).WithName("Consume");
        var absent = provider.GetMessages(queueName: () => queue, messageCount: () => 1).WithName("AfterDelete");
        var result = WorkflowActions.BuiltIn.Compose<JToken>(() => received.Value).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response");
        IChainableNode chain = trigger;
        foreach (var seed in seeds) chain = chain.Then(seed);
        chain.Then(create).Then(received).Then(send).Then(read).Then(consume).Then(absent).Then(result).Then(response);
        return WorkflowFactory.CreateStatefulWorkflow(name, trigger);
    }
}
