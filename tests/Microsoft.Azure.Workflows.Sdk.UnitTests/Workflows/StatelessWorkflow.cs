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
        public FlowPropertiesDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "hello");
            compose.Name = "ComposeOutput";

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => compose.Output);
            response.Name = "Response";

            trigger
                .Then(compose)
                .Then(response);

            return new[] { WorkflowFactory.CreateStatelessWorkflow("TestStatelessWorkflow", trigger) };
        }
    }
}
