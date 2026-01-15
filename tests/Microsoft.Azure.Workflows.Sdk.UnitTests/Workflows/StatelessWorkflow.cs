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
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            trigger.WithName("HttpTrigger");

            var builder = WorkflowBuilderFactory.CreateStatelessWorkflow("TestStatelessWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "hello");
            compose.WithName("ComposeOutput");
            builder.AddAction(compose);

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => compose.Output);
            response.WithName("Response");
            builder.AddAction(response);
        }
    }
}
