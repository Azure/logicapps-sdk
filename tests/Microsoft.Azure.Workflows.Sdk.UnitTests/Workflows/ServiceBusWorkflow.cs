// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Sample workflow that triggers when a message is received from Azure Service Bus.
    /// </summary>
    public class ServiceBusWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the Service Bus queue trigger workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.Managed.Servicebus("servicebus").GetMessageFromQueue(
                queueName: () => "my-queue",
                triggerName: "When_a_message_is_received_in_a_queue");

            var processMessage = WorkflowActions.BuiltIn.Compose(() => new
            {
                MessageId = trigger.TriggerBody.MessageId,
                Content = trigger.TriggerBody.Content,
                ContentType = trigger.TriggerBody.ContentType,
                SessionId = trigger.TriggerBody.SessionId,
                CorrelationId = trigger.TriggerBody.CorrelationId,
                Label = trigger.TriggerBody.Label
            }).WithName("Process_Message");

            trigger.Then(processMessage);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("ServiceBusQueueWorkflow", trigger) };
        }
    }
}
