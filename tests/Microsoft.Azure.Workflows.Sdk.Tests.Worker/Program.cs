// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Reflection;
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Main Program entry point for the test Functions worker with Logic Apps extension.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        public static void Main()
        {
            // Configure the worker with workflow services and providers
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
                    WorkflowFactory.ConfigureServices(services);
                    services.AddWorkflowProvider<HttpWorkflow>();
                    services.AddWorkflowProvider<CustomCodeWorkflow>();
                    services.AddWorkflowProvider<NestedWorkflow>();
                    services.AddWorkflowProvider<RecurrenceWorkflow>();
                    services.AddWorkflowProvider<WeatherWorkflow>();
                    services.AddWorkflowProvider<SerivceNowWorkflow>();
                    services.AddWorkflowProvider<NullableNodeWorkflow>();
                })
                .Build();

            host.Run();
        }
    }
}
