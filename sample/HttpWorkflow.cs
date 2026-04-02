// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk.Agents;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Msnweather;

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
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            WorkflowFactory.CreateStatefulWorkflow("HttpRequestResponse", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"The trigger output {trigger.TriggerOutput.Body}");

            var getCurrentWeatherAction = WorkflowActions.ManagedConnectors.Msnweather("msnweather-3").CurrentWeather(
                location: () => $"{trigger.TriggerOutput.Body}",
                units: () => CurrentWeatherunitsInput.Imperial);

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{getCurrentWeatherAction.Body}");

            trigger
                .Then(compose)
                .Then(getCurrentWeatherAction)
                .Then(response);
        }
    }
}
