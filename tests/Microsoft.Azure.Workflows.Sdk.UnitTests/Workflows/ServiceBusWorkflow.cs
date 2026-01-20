// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Sample workflow that triggers when a message is received from Azure Service Bus.
    /// </summary>
    public static class ServiceBusWorkflow
    {
        /// <summary>
        /// Creates a workflow that triggers on a new message from a Service Bus queue.
        /// </summary>
        public static void AddServiceBusQueueWorkflow()
        {
            // Create Service Bus trigger that fires when a new message arrives in the queue
            /*var trigger = WorkflowTriggers.Managed.Servicebus("servicebus").GetMessageFromQueue(
                queueName: () => "my-queue");
            trigger.WithName("When_a_message_is_received_in_a_queue");
            trigger.WithRecurrence(new FlowRecurrence
            {
                Frequency = FlowRecurrenceFrequency.Minute,
                Interval = 1
            });

            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("ServiceBusQueueWorkflow", trigger);

            // Compose action to process the message content
            var processMessage = WorkflowActions.BuiltIn.Compose(() => new
            {
                MessageId = trigger.TriggerOutput.MessageId,
                Content = trigger.TriggerOutput.Content,
                ContentType = trigger.TriggerOutput.ContentType,
                SessionId = trigger.TriggerOutput.SessionId,
                CorrelationId = trigger.TriggerOutput.CorrelationId,
                Label = trigger.TriggerOutput.Label
            });
            builder.AddAction(processMessage, "Process_Message");*/
        }
    }
}
