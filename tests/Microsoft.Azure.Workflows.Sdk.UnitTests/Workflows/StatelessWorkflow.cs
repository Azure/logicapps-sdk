// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Stateless test workflow.
    /// </summary>
    public class StatelessWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the stateless workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "hello").WithName("Compose");

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => compose.Output).WithName("Response");

            trigger
                .Then(compose)
                .Then(response);

            return new[] { WorkflowFactory.CreateStatelessWorkflow("TestStatelessWorkflow", trigger) };
        }
    }
}
