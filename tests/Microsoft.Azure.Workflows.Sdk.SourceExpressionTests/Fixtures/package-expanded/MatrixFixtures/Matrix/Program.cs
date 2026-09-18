using Microsoft.Azure.Workflows.Sdk;
using Newtonsoft.Json;

internal static class FixtureEntry
{
    public static void Main()
    {
        var sentinel = Environment.GetEnvironmentVariable("WORKFLOW_FIXTURE_EXECUTION_SENTINEL");
        if (!string.IsNullOrEmpty(sentinel)) File.WriteAllText(sentinel, "Authoring application executed.");
        Console.WriteLine(JsonConvert.SerializeObject(new
        {
            result = FixtureWorkflow.Run(),
            framework = AppContext.TargetFrameworkName,
            signed = typeof(FixtureEntry).Assembly.GetName().GetPublicKey()?.Length > 0,
            assemblyName = typeof(FixtureEntry).Assembly.GetName().Name,
        }));
    }
}

internal static class OtherEntry
{
    public static void Main() => throw new InvalidOperationException("StartupObject was not respected.");
}

internal static class FixtureAssert
{
    public static string Input(IWorkflowAction action) =>
        action.GetActionDefinition("PackageMatrix").Inputs?.ToString()
            ?.Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal)
            ?? throw new InvalidOperationException("Expected a non-null action input.");

    public static void Equal(string expected, string actual)
    {
        if (expected != actual) throw new InvalidOperationException($"Expected '{expected}', got '{actual}'.");
    }
}
