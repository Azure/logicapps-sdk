// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Linq;

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
            var providers = new IWorkflowProvider[]
            {
                //new RecruitmentWorkflow(),
                new HttpWorkflow(),
                new CustomCodeWorkflow(),
                new NestedWorkflow(),
                new RecurrenceWorkflow(),
                new EmailWorkflow(),
                new WeatherWorkflow(),
                new ServiceNowWorkflow(),
                new ServiceBusWorkflow(),
                new ServiceBusSendMessageWorkflow(),
                new AzureQueuesWorkflow(),
                new NullableNodeWorkflow(),
                new ComplexBranchWorkflow(),
                new ParallelBranchWorkflow(),
                new ControlWorkflows(),
            };

            var allWorkflows = providers.SelectMany(p => p.GetWorkflows());

            foreach (var workflow in allWorkflows)
            {
                Console.WriteLine($"Workflow: {workflow.Name}");
                Console.WriteLine($"Definition: {workflow.ToJson()}");
                Console.WriteLine();
            }
        }
    }
}
