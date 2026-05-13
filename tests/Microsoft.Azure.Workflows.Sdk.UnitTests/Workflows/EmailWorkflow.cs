// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;

    /// <summary>
    /// Sample workflow that triggers when a new email arrives and composes its content.
    /// </summary>
    public static class EmailWorkflow
    {
        /// <summary>
        /// Creates a workflow that triggers on new email and outputs the body content.
        /// </summary>
        public static void AddEmailWorkflow()
        {
            var trigger = WorkflowTriggers.Managed.Office365("office365").OnNewEmail();
            WorkflowFactory.CreateStatefulWorkflow("GetEmailWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => new EmailContent
            {
                Subject = trigger.TriggerBody.Value[0].Subject,
                Body = trigger.TriggerBody.Value[0].Body,
                From = trigger.TriggerBody.Value[0].From,
                ReceivedTime = trigger.TriggerBody.Value[0].ReceivedTime
            }.ToString()).WithName("ComposeEmailContent");

            trigger.Then(compose);
        }
    }

    /// <summary>
    /// Email content model for compose output.
    /// </summary>
    public class EmailContent
    {
        [JsonProperty(Required = Required.Default)]
        public string Subject { get; set; } = string.Empty;

        [JsonProperty(Required = Required.Default)]
        public string Body { get; set; } = string.Empty;

        [JsonProperty(Required = Required.Default)]
        public string From { get; set; } = string.Empty;

        [JsonProperty(Required = Required.Default)]
        public string ReceivedTime { get; set; } = string.Empty;
    }
}
