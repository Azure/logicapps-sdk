// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Sample workflow that sends an Azure Service Bus message.
    /// </summary>
    public class ServiceBusSendMessageWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the Service Bus send message workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Test compose");

            var sendMessage = WorkflowActions.Managed.Servicebus("servicebus").SendMessage(
                entityName: () => "my-queue",
                messagecontent: () => compose.Output);

            trigger
                .Then(compose)
                .Then(sendMessage);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("ServiceBusSendMessageWorkflow", trigger) };
        }
    }
}
