// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Sample workflow that sends an Azure Service Bus message.
    /// </summary>
    public static class ServiceBusSendMessageWorkflow
    {
        /// <summary>
        /// Creates a workflow that sends a message to a Service Bus queue.
        /// </summary>
        public static void AddServiceBusSendMessageWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            WorkflowFactory.CreateStatefulWorkflow("ServiceBusSendMessageWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Test compose");

            var sendMessage = WorkflowActions.ManagedConnectors.Servicebus("servicebus").SendMessage(
                entityName: () => "my-queue",
                messagecontent: () => compose.Output);

            trigger
                .Then(compose)
                .Then(sendMessage);
        }
    }
}
