using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.Connectors;
using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;
using System.Net;

namespace MyWorkflowExperiment
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Creating workflows...\n");

            // Example 1: Simple HTTP request/response workflow
            CreateSimpleHttpWorkflow();

            // Example 2: Weather lookup workflow
            CreateWeatherWorkflow();

            // Example 3: Scheduled workflow with recurrence
            CreateScheduledWorkflow();

            // Example 4: HTTP external API call
            CreateHttpApiWorkflow();

            // Get the workflow artifacts (JSON definitions)
            var artifacts = WorkflowBuilderFactory.GetCodefulWorkflowArtifacts();

            // Save each workflow definition to a JSON file
            var outputDir = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedWorkflows");
            Directory.CreateDirectory(outputDir);

            Console.WriteLine($"Generated {artifacts.Flows.Count} workflow(s):\n");

            foreach (var flow in artifacts.Flows)
            {
                var fileName = $"{flow.Key}.json";
                var filePath = Path.Combine(outputDir, fileName);
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(flow.Value, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);

                Console.WriteLine($"  ✓ {flow.Key}");
                Console.WriteLine($"    Kind: {flow.Value.Kind}");
                Console.WriteLine($"    File: {filePath}");
                Console.WriteLine();
            }

            Console.WriteLine($"\nAll workflow definitions saved to: {outputDir}");
        }

        /// <summary>
        /// Simple HTTP workflow that echoes back the input with a greeting.
        /// </summary>
        static void CreateSimpleHttpWorkflow()
        {
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
                "SimpleHttpWorkflow",
                WorkflowTriggers.BuiltIn.CreateHttpTrigger());

            var compose = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Hello! You sent: {builder.TriggerOutput.Body}");
            compose.WithName("ComposeGreeting");
            builder.AddAction(compose);

            var response = WorkflowActions.BuiltIn.Response(
                responseBody: () => $"Message: {compose}, Timestamp: {DateTime.UtcNow}");
            response.WithName("SendResponse");
            builder.AddAction(response);
        }

        /// <summary>
        /// HTTP workflow that gets weather for a city from the request body.
        /// POST: { "city": "Seattle" }
        /// </summary>
        static void CreateWeatherWorkflow()
        {
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
                "WeatherLookupWorkflow",
                WorkflowTriggers.BuiltIn.CreateHttpTrigger());

            var getCurrentWeather = WorkflowActions.ManagedConnectors.Msnweather("msnweather-connection")
                .CurrentWeather(
                    location: () => $"{builder.TriggerOutput.Body}",
                    units: () => CurrentWeatherunitsInput.Imperial);
            getCurrentWeather.WithName("GetWeather");
            builder.AddAction(getCurrentWeather);

            var response = WorkflowActions.BuiltIn.Response(
                responseBody: () => $"Weather data: {getCurrentWeather.Body}");
            response.WithName("SendResponse");
            builder.AddAction(response);
        }

        /// <summary>
        /// Scheduled workflow that runs every 10 minutes.
        /// </summary>
        static void CreateScheduledWorkflow()
        {
            var recurrenceTrigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger(
                frequency: FlowRecurrenceFrequency.Minute,
                interval: 10);

            var builder = WorkflowBuilderFactory.CreateStatelessWorkflow(
                "ScheduledWorkflow",
                recurrenceTrigger);

            var compose = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Workflow executed at scheduled time");
            compose.WithName("LogExecution");
            builder.AddAction(compose);
        }

        /// <summary>
        /// HTTP workflow that makes external HTTP calls.
        /// GET request to retrieve data from an API.
        /// </summary>
        static void CreateHttpApiWorkflow()
        {
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
                "HttpApiWorkflow",
                WorkflowTriggers.BuiltIn.CreateHttpTrigger());

            var httpAction = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://jsonplaceholder.typicode.com/posts/1"),
                method: () => HttpMethod.Get);
            httpAction.WithName("GetExternalData");
            builder.AddAction(httpAction);

            var response = WorkflowActions.BuiltIn.Response(
                statusCode: () => HttpStatusCode.OK,
                responseBody: () => $"API Response: {httpAction.Body}");
            response.WithName("SendResponse");
            builder.AddAction(response);
        }
    }
}
