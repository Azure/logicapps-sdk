// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Agents;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Msnweather;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Teams;

    /// <summary>
    /// Weather workflow class.
    /// </summary>
    public class WeatherWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the weather workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.Managed.Msnweather("msnweather").WhenOnCurrentWeatherChange(
                location: () => "Seattle, WA",
                measure: () => OnCurrentWeatherChangeMeasureInput.Temperature,
                when: () => OnCurrentWeatherChangeWhenInput.IsEqualTo,
                target: () => 70,
                units: () => "I"
            );

            trigger.WithName("weather_trigger");
            trigger.WithRecurrence(new FlowRecurrence
            {
                Frequency = FlowRecurrenceFrequency.Minute,
                Interval = 1
            });

            var msg = WorkflowActions.ManagedConnectors.Teams("teams").PostMessageToConversation(
                poster: () => PostMessageToConversationposterInput.User,
                location: () => "Group chat",
                body: () => new
                {
                    recipient = "19:meeting_Y2IyMGY4YmEtNTk1Mi00NjM0LWI4YTYtNDg4M2E3ZTIwMTk1@thread.v2",
                    messageBody = $"The weather changed! The new temperature is °F" + $"{trigger.TriggerBody.Responses.Weather.Current.Temp}"
                });
            trigger.Then(msg);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("MyWeatherWorkflow", trigger) };
        }
    }
}
