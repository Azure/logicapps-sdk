// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

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
            // Create Office365 trigger that fires when a new email arrives
            var trigger = WorkflowTriggers.Managed.Office365("outlook").OnNewEmailV3();
            trigger.WithName("When_a_new_email_arrives");

            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("GetEmailWorkflow", trigger);

            // Compose action to output the email body content
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => new EmailContent
            {
                Subject = trigger.TriggerOutput.Value[0].Subject,
                Body = trigger.TriggerOutput.Value[0].Body,
                From = trigger.TriggerOutput.Value[0].From,
                ReceivedTime = trigger.TriggerOutput.Value[0].ReceivedTime
            }.ToString());
            compose.WithName("ComposeEmailContent");
            builder.AddAction(compose);
        }
    }

    /// <summary>
    /// Email content model for compose output.
    /// </summary>
    public class EmailContent
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public string ReceivedTime { get; set; }
    }
}
