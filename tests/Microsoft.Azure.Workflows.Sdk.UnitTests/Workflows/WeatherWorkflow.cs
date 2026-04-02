// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teams;

    /// <summary>
    /// Weather workflow class.
    /// </summary>
    public static class WeatherWorkflow
    {
        /// <summary>
        /// Adds the weather workflow.
        /// </summary>
        public static void AddWeatherWorkflow()
        {
            var trigger = WorkflowTriggers.Managed.Msnweather("msnweather").OnCurrentWeatherChange(
                location: () => "Seattle, WA",
                measure: () => measureInput.Temperature,
                when: () => whenInput.IsEqualTo,
                target: () => 70,
                units: () => "I"
            );

            WorkflowFactory.CreateStatefulWorkflow("MyWeatherWorkflow", trigger);

            var msg = WorkflowActions.ManagedConnectors.Teams("teams").PostMessageToConversation(
                poster: () => posterInput.User,
                location: () => "Group chat",
                body: () => new
                {
                    recipient = "19:meeting_Y2IyMGY4YmEtNTk1Mi00NjM0LWI4YTYtNDg4M2E3ZTIwMTk1@thread.v2",
                    messageBody = $"The weather changed! The new temperature is °F" + $"{trigger.TriggerBody.Responses.Weather.Current.Temperature}"
                });

            trigger.Then(msg);
        }
    }
}
