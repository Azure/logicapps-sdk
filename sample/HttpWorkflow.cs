// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Agents;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Msnweather;

    /// <summary>
    /// HTTP request/response flow.
    /// </summary>
    public class HttpWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the HTTP request/response workflow definitions.
        /// </summary>
        public FlowPropertiesDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"The trigger output {trigger.TriggerOutput.Body}");

            var getCurrentWeatherAction = WorkflowActions.ManagedConnectors.Msnweather("msnweather-3").CurrentWeather(
                location: () => $"{trigger.TriggerOutput.Body}",
                units: () => CurrentWeatherunitsInput.Imperial);

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{getCurrentWeatherAction.Body}");

            trigger
                .Then(compose)
                .Then(getCurrentWeatherAction)
                .Then(response);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("HttpRequestResponse", trigger) };
        }
    }
}
