// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// HTTP request/response test workflow.
    /// </summary>
    public static class HttpWorkflow
    {
        /// <summary>
        /// Adds the HTTP request/response workflow.
        /// </summary>
        public static void AddHttpRequestResponseWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("TestHttpRequestResponse", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Received request: {trigger.TriggerOutput.Body}");
            builder.AddAction(compose, "ComposeInput");

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"Hello from test workflow! Input was: {compose.Output}");
            builder.AddAction(response, "HttpResponse");
        }
    }
}
