// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;

    /// <summary>
    /// HTTP request/response flow.
    /// </summary>
    public static class HttpWorkflow
    {
        /// <summary>
        /// Adds the HTTP request/response workflow.
        /// </summary>
        public static void AddHttpRequestResponseWorkflow()
        {
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("HttpRequestResponse", WorkflowTriggers.BuiltIn.CreateHttpTrigger());
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"The trigger output {builder.TriggerOutput.Body}");
            builder.AddAction(compose);

            var getCurrentWeatherAction = WorkflowActions.ManagedConnectors.Msnweather("msnweather-3").CurrentWeather(
                location: () => $"{builder.TriggerOutput.Body}",
                units: () => CurrentWeatherunitsInput.Imperial);
            builder.AddAction(getCurrentWeatherAction);

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{getCurrentWeatherAction.Body}");
            builder.AddAction(response);
        }
    }
}
