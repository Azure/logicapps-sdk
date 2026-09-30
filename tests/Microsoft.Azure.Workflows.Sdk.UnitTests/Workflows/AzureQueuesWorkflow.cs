// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Sample workflows using the Azure Queues built-in service provider for both
    /// trigger-based message receive and action-based message send/delete operations.
    /// </summary>
    public class AzureQueuesWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the Azure Queues workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            return new[]
            {
                AzureQueuesWorkflow.CreateTriggerWorkflow(),
                AzureQueuesWorkflow.CreateActionWorkflow(),
            };
        }

        /// <summary>
        /// Creates a workflow that triggers when a message is received on an Azure Queue
        /// and processes the message content.
        /// </summary>
        private static FlowDefinition CreateTriggerWorkflow()
        {
            var trigger = WorkflowTriggers.ServiceProviders.Azurequeues("azureQueuesConnection")
                .ReceiveQueueMessages(
                    queueName: () => "incoming-messages")
                .WithName("When_messages_are_available_in_a_queue");

            var logMessage = WorkflowActions.BuiltIn.Compose(() => new
            {
                MessageText = trigger.TriggerBody.MessageText,
                MessageId = trigger.TriggerBody.MessageId,
                InsertedOn = trigger.TriggerBody.InsertedOn,
            }).WithName("Log_Queue_Message");

            var deleteMessage = WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
                .DeleteMessage(
                    queueName: () => "incoming-messages",
                    messageId: () => $"{trigger.TriggerBody.MessageId}",
                    popReceipt: () => $"{trigger.TriggerBody.PopReceipt}")
                .WithName("Delete_Processed_Message");

            trigger
                .Then(logMessage)
                .Then(deleteMessage);

            return WorkflowFactory.CreateStatefulWorkflow("AzureQueuesReceiveMessages", trigger);
        }

        /// <summary>
        /// Creates a workflow triggered by HTTP that sends a message to an Azure Queue
        /// and lists available queues.
        /// </summary>
        private static FlowDefinition CreateActionWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");

            var sendMessage = WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
                .PutMessage(
                    queueName: () => "outgoing-messages",
                    message: () => $"Request received: {trigger.TriggerOutput.Body}")
                .WithName("Send_Queue_Message");

            var logResult = WorkflowActions.BuiltIn.Compose(() => new
            {
                SentMessageId = sendMessage.Output.MessageId,
                ExpiresOn = sendMessage.Output.ExpiresOn,
            }).WithName("Log_Send_Result");

            var listQueues = WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
                .ListQueues(prefix: () => "outgoing")
                .WithName("List_Queues");

            var response = WorkflowActions.BuiltIn.Response(
                responseBody: () => $"Message sent: {sendMessage.Output.MessageId}, Queues: {listQueues.Body}")
                .WithName("HttpResponse");

            trigger
                .Then(sendMessage)
                .Then(logResult)
                .Then(listQueues)
                .Then(response);

            return WorkflowFactory.CreateStatefulWorkflow("AzureQueuesSendMessage", trigger);
        }
    }
}
