// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
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
            // Configure the worker with workflow services
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services => WorkflowBuilderFactory.ConfigureServices(services))
                .Build();

            EmailWorkflow.AddEmailWorkflow();
            //HttpWorkflow.AddHttpRequestResponseWorkflow();
            //StatefulWorkflow.AddStatefulWorkflowWithCustomCode();
            //StatelessWorkflow.AddStatelessWorkflow();
            //RecurrenceWorkflow.AddRecurrenceWorkflow();
            //WeatherWorkflow.AddWeatherWorkflow();

            host.Run();
        }
    }
}
