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
    public class EmailWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the email workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.Managed.Office365("office365").OnNewEmail();

            var compose = WorkflowActions.BuiltIn.Compose(
                inputs: () => JsonConvert.SerializeObject(
                    new
                    {
                        Subject = trigger.TriggerBody.Value[0].Subject,
                        Body = trigger.TriggerBody.Value[0].Body,
                        From = trigger.TriggerBody.Value[0].From,
                        ReceivedTime = trigger.TriggerBody.Value[0].ReceivedTime,
                    })).WithName("ComposeEmailContent");

            trigger.Then(compose);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("GetEmailWorkflow", trigger) };
        }
    }
}
