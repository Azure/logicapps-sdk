using System.Globalization;
using System.Text.Json;

public static class StartupHook
{
    public static void Initialize()
    {
        var name = Environment.GetEnvironmentVariable("WORKFLOW_PROBE_CULTURE");
        var output = Environment.GetEnvironmentVariable("WORKFLOW_PROBE_CULTURE_EVIDENCE");
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(output))
            throw new InvalidOperationException("The isolated host probe requires culture and evidence-path settings.");
        var culture = CultureInfo.GetCultureInfo(name);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
        File.WriteAllText(output, JsonSerializer.Serialize(new
        {
            culture = CultureInfo.CurrentCulture.Name,
            defaultThreadCulture = CultureInfo.DefaultThreadCurrentCulture.Name,
            processId = Environment.ProcessId,
            runtime = Environment.Version.ToString(),
            startedUtc = DateTimeOffset.UtcNow,
        }));
        Console.WriteLine($"WORKFLOW_PROBE_CULTURE={culture.Name}; process={Environment.ProcessId}");
    }
}
