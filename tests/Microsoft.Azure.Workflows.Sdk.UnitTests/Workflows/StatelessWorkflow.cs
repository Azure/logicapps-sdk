// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Stateless test workflow.
    /// </summary>
    public static class StatelessWorkflow
    {
        /// <summary>
        /// Adds a simple stateless workflow.
        /// </summary>
        public static void AddStatelessWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            WorkflowFactory.CreateStatelessWorkflow("TestStatelessWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "hello");
            compose.Name = "ComposeOutput";

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => compose.Output);
            response.Name = "Response";

            trigger
                .Then(compose)
                .Then(response);
        }
    }
}
