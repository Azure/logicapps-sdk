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
            WorkflowFactory.CreateStatefulWorkflow("TestHttpRequestResponse", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Received request: {trigger.TriggerOutput.Body}").WithName("ComposeInput");

            var sharepoint = WorkflowActions.ManagedConnectors.Sharepointonline("sharepoint").GetItems(
                dataset: () => "https://microsoft.sharepoint.com/teams/ApiHubDevTeam",
                table: () => "1149655b-8044-4cec-90ff-701720a5f89a").WithName("GetItems");

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"Hello from test workflow! Input was: {compose.Output} {sharepoint.Body}").WithName("HttpResponse");

            trigger
                .Then(compose)
                .Then(sharepoint)
                .Then(response);
        }
    }
}
