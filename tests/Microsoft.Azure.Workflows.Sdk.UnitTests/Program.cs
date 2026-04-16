// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    /// <summary>
    /// Main Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Class.
        /// </summary>
        public static void Main()
        {
            //RecruitmentWorkflow.AddRecruitmentWorkflow();

            HttpWorkflow.AddHttpRequestResponseWorkflow();
            CustomCodeWorkflow.AddStatefulWorkflowWithCustomCode();

            NestedWorkflow.AddNestedWorkflow();

            RecurrenceWorkflow.AddRecurrenceWorkflow();
            EmailWorkflow.AddEmailWorkflow();

            WeatherWorkflow.AddWeatherWorkflow();

            SerivceNowWorkflow.AddWorkflow();

            ServiceBusWorkflow.AddServiceBusQueueWorkflow();
            ServiceBusSendMessageWorkflow.AddServiceBusSendMessageWorkflow();

            NullableNodeWorkflow.AddNullableNodeWorkflow();

            JoinWorkflow.GetJoinWorkflow();
            JoinWorkflow.GetJoinWithRunAfterWorkflow();

            var workflowArtifacts = WorkflowFactory.GetCodefulWorkflowArtifacts();

            foreach (var workflow in workflowArtifacts.Flows)
            {
                Console.WriteLine($"Workflow: {workflow.Key}");
                Console.WriteLine($"Definition: {workflow.Value.ToJson()}");
                Console.WriteLine();
            }
        }
    }
}
