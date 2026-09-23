using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;
using Microsoft.Extensions.Hosting;

if (args is ["--compare", var ours, var comparison, var comparisonOutput])
{
    ComparisonReport.Write(ours, comparison, comparisonOutput);
    return 0;
}
if (args is ["--self-test"])
{
    ComparisonReport.SelfTest();
    return 0;
}
if (args is ["--validate-results", var resultsFile])
{
    return ComparisonReport.ValidateResults(resultsFile) ? 0 : 1;
}

if (args is ["--export", var destination])
{
    var cases = CaseCatalog.Build();
    CaseCatalog.Write(destination, cases);
    Console.WriteLine($"Exported {cases.Count(result => result.Workflow != null)} workflows; " +
        $"{cases.Count(result => !result.GenerationExpectationMet)} generation-contract failures.");
    return cases.All(result => result.GenerationExpectationMet) ? 0 : 1;
}
if (args.Length != 0 && !args.Contains("--host") && !args.Contains("--functions-uri"))
    throw new ArgumentException("Expected --export, --compare, --validate-results, --self-test, or Functions worker arguments.");

new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        WorkflowFactory.ConfigureServices(services);
        services.AddWorkflowProvider<RegressionWorkflows>();
    })
    .Build()
    .Run();
return 0;

public sealed class RegressionWorkflows : IWorkflowProvider
{
    private static readonly Lazy<CaseResult[]> Cases = new(CaseCatalog.Build);

    public FlowDefinition[] GetWorkflows()
    {
        var destination = Environment.GetEnvironmentVariable("E2E_RESULTS_DIRECTORY")
            ?? throw new InvalidOperationException("E2E_RESULTS_DIRECTORY must name the isolated run's definitions directory.");
        CaseCatalog.Write(destination, Cases.Value);
        return Cases.Value.Where(result => result.Workflow != null).Select(result => result.Workflow)
            .Append(ReadinessWorkflow.Create()).ToArray();
    }
}

public static class ReadinessWorkflow
{
    public static FlowDefinition Create()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => "ready").WithName("Response");
        trigger.Then(response);
        return WorkflowFactory.CreateStatefulWorkflow("E2EReady", trigger);
    }
}
